using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReportesIosepSalud
    {
        public int ReportesIosepSaludID { get; set; }
        public int EmpresaID { get; set; }
        public string Periodo { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Reporte { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool? Generada { get; set; }
        public string? UsuarioGenera { get; set; }
        public DateTime? FechaGenera { get; set; }
        public int? IdCtaCte { get; set; }
    }
}
