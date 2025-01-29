
using Microsoft.AspNetCore.Mvc;
using ApiIosep.Models.Persona;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Controllers
{

    //[Route("api/[controller]")]
    [Route("api/Users")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginService loginService;

        public LoginController(ILoginService loginservice)
        {
            loginService = loginservice;
        }

        [HttpPost]
        //[Route("Autenticarse")]
        public async Task<ActionResult> Login(Login datos)
        {
            datos.User = datos.User.ToLower();
            var user = await loginService.GetUser(datos.User, datos.Password);

            if (user.Data == null)
            {
                ModelState.AddModelError("Error", "Usuario y/o contraseña no son válidas");

                return BadRequest(ModelState);
            }
            return Ok(user.Data);

        }


        // GET: api/Users/Extras/Hora
        [HttpGet("Extras/Fecha/{format}/{command}")]
        public IActionResult GetFecha(string format = "yyyy-MM-dd", string command = "fecha")
        {
            string fecha = "", desde = "", hasta = "";
            DateTime date = DateTime.Now;
            DateTime today = DateTime.Today;
            switch (command)
            {
                case "firstDayMonth":
                    desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
                    break;
                case "lastDayMonth":
                    desde = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
                    break;
                case "firstDayYear":
                    desde = (new DateTime(date.Year, 1, 1)).ToString(format);
                    break;
                case "lastDayYear":
                    desde = (new DateTime(date.Year, 12, 31)).ToString(format);
                    break;
                case "periodYear":
                    desde = (new DateTime(date.Year, 1, 1)).ToString(format);
                    hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
                    break;
                case "periodMonthDay":
                    desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
                    hasta = date.ToString(format);
                    break;
                case "periodMonth":
                    desde = (new DateTime(date.Year, date.Month, 1)).ToString(format);
                    hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
                    break;
                case "iosepSalud":
                    desde = (new DateTime(2022, 12, 1)).ToString(format);
                    hasta = (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(today.Year, today.Month))).ToString(format);
                    break;
                case "fecha":
                default:
                    desde = date.ToString(format);
                    break;
            }
            fecha = "{\"desde\":\"" + desde + "\"}";
            if (!string.IsNullOrEmpty(hasta))
                fecha = "{\"desde\":\"" + desde + "\",\"hasta\":\"" + hasta + "\"}";
            return Ok(fecha);
        }

    }
}
