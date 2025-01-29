using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CtaCte_DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int? IdCtaCte_IosepSalud { get; set; }
        public int? IdCtaCte { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdDetalle { get; set; }
        public string? Numero_Comprobante { get; set; }
        public decimal? Importe { get; set; }
        public string? CodigoBarra { get; set; }
        public string? Periodo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? Fecha_Emision { get; set; }
        public DateTime? Facturacion_Global { get; set; }
        public string? Cupon_Coseguro { get; set; }
        public string? DetalleFactura { get; set; }
        public bool Anulado { get; set; }
        public string? AfiliadosIncorporados { get; set; }
    }
}
