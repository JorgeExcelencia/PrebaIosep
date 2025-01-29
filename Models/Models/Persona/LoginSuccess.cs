namespace ApiIosep.Models.Persona
{
    public class LoginSuccess
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }
        public string? RefreshToken { get; set; } //por ahora no se utiliza por no
                                                  //terminar de comprender la logica y que beneficios nos podria aportar
    }
}
