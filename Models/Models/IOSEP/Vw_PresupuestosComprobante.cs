using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_PresupuestosComprobante
    {
        public int FormaPagoCodigo { get; set; }
        public string Comprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string FormaPagoDetalle { get; set; } = null!;
        public int? Cantidad { get; set; }
        public string? CodigoPractica { get; set; }
        public string? NombrePractica { get; set; }
        public decimal? TotalIosep { get; set; }
        public decimal? TotalCoseguro { get; set; }
        public int IdAfiliado { get; set; }
        public string? Cuil { get; set; }
        public string? Nombre { get; set; }
        public decimal Total { get; set; }
        public string? Tipo { get; set; }
        public bool Anulado { get; set; }
    }
}
