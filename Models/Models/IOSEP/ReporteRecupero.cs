using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReporteRecupero
    {
        public int ReporteRecuperoID { get; set; }
        public DateTime FechaReporte { get; set; }
        public string UsuarioReporte { get; set; } = null!;
        public int? CantidadRegistros { get; set; }
        public bool Anulado { get; set; }
        public string? Desde { get; set; }
        public string? Hasta { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}
