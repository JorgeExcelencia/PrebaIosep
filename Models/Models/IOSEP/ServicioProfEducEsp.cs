using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ServicioProfEducEsp
    {
        public int ServicioPEEID { get; set; }
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
