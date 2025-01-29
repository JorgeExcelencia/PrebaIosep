using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleVentaPendiente
    {
        public FarDetalleVentaPendiente()
        {
            FarDetalleEntregaMedicacionPendientes = new HashSet<FarDetalleEntregaMedicacionPendiente>();
        }

        public int FarDetalleVentaPendienteId { get; set; }
        public int FarVentaPendienteId { get; set; }
        public int NroRegistro { get; set; }
        public int? NuevaDro { get; set; }
        public int? MultiDro { get; set; }
        public string? Presentacion { get; set; }
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public bool Trazado { get; set; }
        public string? Lote { get; set; }
        public string? Vence { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }

        public virtual FarVentaPendiente FarVentaPendiente { get; set; } = null!;
        public virtual ICollection<FarDetalleEntregaMedicacionPendiente> FarDetalleEntregaMedicacionPendientes { get; set; }
    }
}
