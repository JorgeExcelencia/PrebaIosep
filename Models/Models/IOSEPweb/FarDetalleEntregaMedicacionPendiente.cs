using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleEntregaMedicacionPendiente
    {
        public int FarDetalleEntregaMedicacionPendienteId { get; set; }
        public int FarEntregaMedicacionPendienteId { get; set; }
        public int FarDetalleVentaPendienteId { get; set; }
        public int NroRegistro { get; set; }
        public string? Presentacion { get; set; }
        public string? CodigoBarras { get; set; }
        public decimal CantidadSolicita { get; set; }
        public decimal CantidadEntrega { get; set; }
        public decimal PrecioEntrega { get; set; }
        public decimal Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual FarDetalleVentaPendiente FarDetalleVentaPendiente { get; set; } = null!;
        public virtual FarEntregaMedicacionPendiente FarEntregaMedicacionPendiente { get; set; } = null!;
    }
}
