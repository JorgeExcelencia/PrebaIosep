using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleEntregaMedicacion
    {
        public FarDetalleEntregaMedicacion()
        {
            FarEmPresentacionComprobanteDetalles = new HashSet<FarEmPresentacionComprobanteDetalle>();
        }

        public int FarDetalleEntregaMedicacionId { get; set; }
        public int FarEntregaMedicacionId { get; set; }
        public int FarDetalleVentaId { get; set; }
        public int NroRegistro { get; set; }
        public string Presentacion { get; set; } = null!;
        public string? CodigoBarras { get; set; }
        public decimal CantidadSolicita { get; set; }
        public decimal CantidadEntrega { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioEntrega { get; set; }
        public decimal Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual FarEntregaMedicacion FarEntregaMedicacion { get; set; } = null!;
        public virtual ICollection<FarEmPresentacionComprobanteDetalle> FarEmPresentacionComprobanteDetalles { get; set; }
    }
}
