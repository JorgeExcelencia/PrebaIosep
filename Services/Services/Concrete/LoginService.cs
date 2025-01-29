using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEPweb;
using ApiIosep.Models.Persona;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ApiIosep.Services
{
    public class LoginService : ILoginService
    {

        //private ApplicationSignInManager _signInManager;
        private IAspNetUsers1Repository _users1Repository;
        private IConfiguration config;
        private PasswordHasher _passwordHasher;


        public LoginService(IAspNetUsers1Repository users1Repository, IConfiguration config)
        {
            _users1Repository = users1Repository;
            this.config = config;
            _passwordHasher = new PasswordHasher();
        }

        public async Task<Response<LoginSuccess>> GetUser(string cuil, string password)
        {
            var resp = new Response<LoginSuccess>();
            LoginSuccess result = new LoginSuccess();
            try
            {

                var user = await _users1Repository.UserByCuil(cuil);

                if (user == null)
                {
                    return null;
                }

                var res = _passwordHasher.VerifyHashedPassword(user.PasswordHash, password);
                if (res == PasswordVerificationResult.Failed)
                {
                    return null;
                }


                string token = GetToken(user);

                result.User = user.UserName;
                result.Email = user.Email ?? "";
                result.Phone = user.PhoneNumber ?? "";
                result.Token = token;
                result.RefreshToken = GetRefreshToken(user.UserName).Token;

                resp.Data = result;
            }
            catch (Exception e)
            {

                resp.Error = true;
                resp.Message = e.Message;
            }
            
                return resp;
        }

        private string GetToken(AspNetUser1 user)
        {
            List<string> roles = user.Roles.Select(a => a.Name).ToList();
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                };

            // Agregar cada rol como un `Claim` individual
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("JWT:Key").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );

            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return token;
        }

        private RefreshToken GetRefreshToken(string username)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expiracion = DateTime.Now.AddDays(7),
                Creado = DateTime.Now,
                CreadoPor = username
            };
        }

        private string RandomTokenString()
        {
            var randomByte = new byte[40];
            RandomNumberGenerator.Fill(randomByte);
            //return Encoding.ASCII.GetString(randomByte).Replace("-", "").;

            return Convert.ToBase64String(randomByte).Replace("+", "").Replace("/", "").Replace("=", "");
        }


    }
}
