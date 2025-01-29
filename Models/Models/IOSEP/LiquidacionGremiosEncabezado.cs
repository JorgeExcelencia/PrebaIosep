using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LiquidacionGremiosEncabezado
    {
        public LiquidacionGremiosEncabezado()
        {
            LiquidacionGremiosDetalles = new HashSet<LiquidacionGremiosDetalle>();
        }

        public int LiquidacionGremiosEncabezadoID { get; set; }
        public int GremioID { get; set; }
        public string Periodo { get; set; } = null!;
        public int ObraSocialID { get; set; }
        public string? NumeroFactura { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }

        public virtual Gremio Gremio { get; set; } = null!;
        public virtual ICollection<LiquidacionGremiosDetalle> LiquidacionGremiosDetalles { get; set; }
    }
}
