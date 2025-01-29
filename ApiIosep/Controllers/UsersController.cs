using Microsoft.AspNetCore.Mvc;
using ApiIosep.Repositories;

namespace ApiIosep.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/UsersViejo")]
    [ApiController]
    public class UsersController : ControllerBase
    {
     private readonly SqlDBContext _context;

        //private readonly IOSEPwebContext _contextWeb;

        //private readonly LoginService loginService;
        //private PasswordHasher passwordHasher;

        //public UsersController(SqlDBContext context, LoginService l, IOSEPwebContext web)
        //{
        //    _context = context;
        //    _contextWeb = web;
        //    loginService = l;
        //    passwordHasher = new PasswordHasher();
        //}

        // GET: api/Users
        //[HttpGet]
        //public async Task<IActionResult> GetUserByToken(string usuario, string token)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(f => f.Token == token && (f.Email == usuario || f.UserID == usuario));
        //    if (user == null)
        //    {
        //        ModelState.AddModelError("Error", "Usuario y/o contraseña no son válidas");
        //        return BadRequest(ModelState);
        //    }

        //    if (user.IsLockedOut)
        //    {
        //        ModelState.AddModelError("Error", "Usuario bloqueado por varios intentos erroneos");
        //        return BadRequest(ModelState);
        //    }

        //    Config.Application["usuario"] = user.UserID;
        //    Config.Application["email"] = user.Email;
        //    Config.Application["sucursal"] = user.Sucursal;
        //    Config.Application["roles"] = user.Roles;
        //    Config.Application["appName"] = "IOSEP";

        //    return Ok(true);
        //}

        //[HttpGet("{pass}")]
        //public ActionResult<string> GetPass(string pass)
        //{
        //    return getPassword(pass, false);
        //}

        //// GET: api/Users/Extras/Hora
        //[HttpGet("Extras/Fecha/{format}/{command}")]
        //public IActionResult GetFecha(string format = "yyyy-MM-dd", string command = "fecha")
        //{
        //    string fecha = "", desde = "", hasta = "";
        //    DateTime date = DateTime.Now;
        //    DateTime today = DateTime.Today;
        //    switch (command)
        //    {
        //        case "firstDayMonth":
        //            desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
        //            break;
        //        case "lastDayMonth":
        //            desde = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
        //            break;
        //        case "firstDayYear":
        //            desde = (new DateTime(date.Year, 1, 1)).ToString(format);
        //            break;
        //        case "lastDayYear":
        //            desde = (new DateTime(date.Year, 12, 31)).ToString(format);
        //            break;
        //        case "periodYear":
        //            desde = (new DateTime(date.Year, 1, 1)).ToString(format);
        //            hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
        //            break;
        //        case "periodMonthDay":
        //            desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
        //            hasta = date.ToString(format);
        //            break;
        //        case "periodMonth":
        //            desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
        //            hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
        //            break;
        //        case "iosepSalud":
        //            desde = (new DateTime(2022, 12, 1)).ToString(format);
        //            hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
        //            break;
        //        case "fecha":
        //        default:
        //            desde = date.ToString(format);
        //            break;
        //    }
        //    fecha = "{\"desde\":\"" + desde + "\"}";
        //    if (!string.IsNullOrEmpty(hasta))
        //        fecha = "{\"desde\":\"" + desde + "\",\"hasta\":\"" + hasta + "\"}";
        //    return Ok(fecha);
        //}

        ////// POST: api/Users
        ////// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        ////[HttpPost]
        ////public async Task<ActionResult> Login([FromBody] Login usuario)
        ////{
        ////    string pass = getPassword(usuario.Password, false);
        ////    var user = await _context.Users.FirstOrDefaultAsync(x => x.Password == pass && (x.UserID == usuario.User || x.Email == usuario.User));
        ////    if (user == null)
        ////    {
        ////        ModelState.AddModelError("Error", "Usuario y/o contraseña no son válidas");
        ////        return BadRequest(ModelState);
        ////    }
        ////    //BadRequest (400)
        ////    //Created (201)
        ////    //InternalServerError (500)
        ////    //Ok (200)
        ////    //NotFound()
        ////    //Unauthorized (401)

        ////    if (user.IsLockedOut)
        ////    {
        ////        ModelState.AddModelError("Error", "Usuario bloqueado por varios intentos erroneos");
        ////        return BadRequest(ModelState);
        ////    }

        ////    LoginSuccess result = new LoginSuccess();
        ////    result.User = user.UserID;
        ////    result.Email = user.Email;
        ////    result.Phone = user.Phone;
        ////    result.Token = await generateToken(user.Id);
        ////    if (result.Token == "NO")
        ////    {
        ////        ModelState.AddModelError("Error", "Error de login.");
        ////        return BadRequest(ModelState);
        ////    }

        ////    return Ok(result);
        ////}


        //// POST: api/Users
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult> Login([FromBody] Login usuario)
        //{
        //    var user = await loginService.GetUser(usuario.User, usuario.Password);
        //    if (user.Data == null)
        //    {
        //        ModelState.AddModelError("Error", "Usuario y/o contraseña no son válidas");
        //        return BadRequest(ModelState);
        //    }


        //    return Ok(user.Data);
        //}


        //////PUT: api/Users/
        ////[HttpPut]
        ////public async Task<ActionResult> Create()
        ////{

        ////}

        //#region Privado
        ///// <summary>
        ///// Genera el token para autenticar el usuario.
        ///// </summary>
        ///// <param name="id">Id de usuario</param>
        ///// <returns></returns>
        //private async Task<string> generateToken(string id)
        //{
        //    string token = Tools.RandomString(7, false, false);

        //    string result = await UpdateToken(id, token); //COMENTADO DEBIDO A QUE TIRA ERROR AL DARLE SAVECHANGE CON IDDIGITALIZAR PORQUE USAR IDENTITY

        //    //string result = "OK";
        //    if (result == "ERROR")
        //        return "NO";
        //    return token;
        //}

        ///// <summary>
        ///// Grabo en el usuario el token que se genero.
        ///// </summary>
        ///// <param name="id">Id del usuario</param>
        ///// <param name="token">token a grabar.</param>
        ///// <returns>Devuelve OK si esta correcto.</returns>
        ///// 
        ////private async Task<string> UpdateToken(int id, string token)
        ////{
        ////    var user = _context.Users.FindAsync(id).Result;
        ////    if (user != null)
        ////    {
        ////        user.LastAccess = DateTime.Now;
        ////        user.Token = token;
        ////        _context.Entry(user).State = EntityState.Modified;
        ////        try
        ////        {
        ////            await _context.SaveChangesAsync();
        ////            return "OK";
        ////        }
        ////        catch (DbUpdateConcurrencyException)
        ////        {

        ////        }
        ////    }
        ////    return "ERROR";
        ////}

        //private async Task<string> UpdateToken(string id, string token)
        //{
        //    var user = _contextWeb.AspNetUsers1.FindAsync(id).Result;
        //    if (user != null)
        //    {
        //        user.Token = token;

        //        _contextWeb.AspNetUsers1.Attach(user);
        //        _contextWeb.Entry(user).Property(x => x.Token).IsModified = true;
        //    try
        //    {
        //            await _contextWeb.SaveChangesAsync();
        //            return "OK";
        //    }
        //        catch (DbUpdateConcurrencyException)
        //    {

        //    }
        //}
        //    return "ERROR";
        //}

        ///// <summary>
        ///// Codifico contraseña.
        ///// </summary>
        ///// <param name="source">Código a codificar</param>
        ///// <param name="verifyPass">Indica si se verifica.</param>
        ///// <returns>Si se verifica correctamente devuelve ok, sino verifica devuelve el hash generdado</returns>
        //private string getPassword(string source, bool verifyPass)
        //{
        //    using (SHA256 sha256Hash = SHA256.Create())
        //    {
        //        string hash = GetHash(sha256Hash, source);

        //        if (VerifyHash(sha256Hash, source, hash))
        //        {
        //            if (verifyPass)
        //                return "Ok";
        //            else
        //                return hash;
        //        }
        //        else
        //            return "Error";
        //    }
        //}

        //private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        //{

        //    byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
        //    var sBuilder = new StringBuilder();

        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sBuilder.Append(data[i].ToString("x2"));
        //    }

        //    return sBuilder.ToString();
        //}

        //private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        //{
        //    var hashOfInput = GetHash(hashAlgorithm, input);

        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    return comparer.Compare(hashOfInput, hash) == 0;
        //}
        //#endregion
    }
}
