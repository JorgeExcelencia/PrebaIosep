using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEmPresentacionComprobanteDetalle
    {
        public int FarEmpresentacionComprobanteDetalleId { get; set; }
        public int FarEmpresentacionComprobanteId { get; set; }
        public int FarEmpresentacionId { get; set; }
        public int FarDetalleEntregaMedicacionId { get; set; }
        public int? TipoDebitoId { get; set; }
        public int NroRegistro { get; set; }
        public string Presentacion { get; set; } = null!;
        public string? CodigoBarras { get; set; }
        public decimal ImporteEntrega { get; set; }
        public decimal Cobertura { get; set; }
        public decimal CantidadEntrega { get; set; }
        public decimal CoseguroAfiliado { get; set; }
        public decimal CoseguroIosep { get; set; }
        public decimal? DebitoImporte { get; set; }
        public string? DebitoDetalle { get; set; }
        public DateTime CreaFecha { get; set; }
        public string CreaOp { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual FarDetalleEntregaMedicacion FarDetalleEntregaMedicacion { get; set; } = null!;
        public virtual FarEmPresentacion FarEmpresentacion { get; set; } = null!;
        public virtual FarEmPresentacionComprobante FarEmpresentacionComprobante { get; set; } = null!;
    }
}
