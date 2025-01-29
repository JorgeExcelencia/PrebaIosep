using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoTransporte
    {
        public int TipoTransporteID { get; set; }
        public string Descripcion { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperActiva { get; set; }
        public DateTime? FechaActiva { get; set; }
        public string? MotivoActiva { get; set; }
    }
}
