namespace ApiIosep.Services
{
    public class BasicAuthentication /*: IAuthorizationFilter*/
    {
        private readonly string _realm;
        private readonly LoginService loginServ;

        public BasicAuthentication(string realm, LoginService s)
        {
            _realm = realm;
            if (string.IsNullOrWhiteSpace(_realm))
            {
                throw new ArgumentNullException(nameof(realm), @"Please provide a non-empty realm value.");
            }

            loginServ = s;
        }
        //public void OnAuthorization(AuthorizationFilterContext context)
        //{
        //    try
        //    {
        //        string authHeader = context.HttpContext.Request.Headers["Authorization"];
        //        if (authHeader != null)
        //        {
        //            var authHeaderValue = AuthenticationHeaderValue.Parse(authHeader);
        //            if (authHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(), StringComparison.OrdinalIgnoreCase))
        //            {
        //                var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty)).Split(':', 2);
        //                if (credentials.Length == 2)
        //                {
        //                    if (IsAuthorized(context, credentials[0], credentials[1]).Result)
        //                    {
        //                        return;
        //                    }
        //                }
        //            }
        //        }

        //        ReturnUnauthorizedResult(context);
        //    }
        //    catch (FormatException)
        //    {
        //        ReturnUnauthorizedResult(context);
        //    }
        //}

        //public async Task<bool> IsAuthorized(AuthorizationFilterContext context, string username, string password)
        //{
        //    var conn = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["WebApiDB"];
        //    DbContextOptionsBuilder<SqlDBContext> optionsBuilder = new();
        //    optionsBuilder.UseSqlServer(conn);
        //    UsersController controller = new UsersController(new SqlDBContext(optionsBuilder.Options), loginServ, new IOSEPwebContext());
        //    IActionResult result = await controller.GetUserByToken(username, password);
        //    var okResult = result as OkObjectResult;
        //    if (okResult != null && okResult.StatusCode == 200)
        //        return true;
        //    else
        //        return false;
        //}

        //private void ReturnUnauthorizedResult(AuthorizationFilterContext context)
        //{
        //    // Return 401 and a basic authentication challenge (causes browser to show login dialog)
        //    context.HttpContext.Response.Headers["WWW-Authenticate"] = $"Basic realm=\"{_realm}\"";
        //    context.Result = new UnauthorizedResult();
        //}
    }
}
