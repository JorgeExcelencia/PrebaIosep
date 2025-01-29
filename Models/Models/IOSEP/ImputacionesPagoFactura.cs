using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ImputacionesPagoFactura
    {
        public int IdImputacionPago { get; set; }
        public string FacturaNueva { get; set; } = null!;
        public decimal Importe { get; set; }
        public string? FacturaAnterior { get; set; }
        public string ComprobantePago { get; set; } = null!;
        public decimal ImportePagado { get; set; }
        public decimal Saldo { get; set; }
        public string? Observaciones { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
