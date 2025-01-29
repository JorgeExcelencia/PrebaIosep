using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestPlanificacion
    {
        public int PrestPlanificacionID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public string Periodo { get; set; } = null!;
        public string UsuarioCrea { get; set; } = null!;
        public string? UsuarioModifica { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime? FechaModifica { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
