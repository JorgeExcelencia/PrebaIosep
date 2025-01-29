using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InsulinoLotesEncabezado
    {
        public int EncabezadoId { get; set; }
        public DateTime Fecha { get; set; }
        public string PeriodoPresentacion { get; set; } = null!;
        public int IdObraSocial { get; set; }
        public DateTime? FechaCierrePresentacion { get; set; }
        public string? OperadorCierrePresentacion { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OperadorCierreAuditoria { get; set; }
        public string? NumeroFactura { get; set; }
        public bool Anuladas { get; set; }
        public string? Cuit { get; set; }
        public string? Cae { get; set; }
        public decimal? TotalPresentado { get; set; }
        public bool Anulado { get; set; }
    }
}
