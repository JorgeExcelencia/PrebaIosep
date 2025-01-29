using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Token
    {
        public int Id_Token { get; set; }
        public string? App { get; set; }
        public string URL { get; set; } = null!;
        public string? CampoPassword { get; set; }
        public string? Password { get; set; }
        public string? CampoUsuario { get; set; }
        public string? Usuario { get; set; }
        public string? Token1 { get; set; }
        public DateTime? ExpiraToken { get; set; }
        public string? Authorization { get; set; }
        public bool Anulado { get; set; }
    }
}
