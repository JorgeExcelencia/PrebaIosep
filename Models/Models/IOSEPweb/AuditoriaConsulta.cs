using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AuditoriaConsulta
    {
        public int IdAuditoriaConsulta { get; set; }
        public int IdDetalle { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public decimal Importe { get; set; }
        public int IdTipoDebito { get; set; }
        public string DetalleDebito { get; set; } = null!;
        public decimal Debitado { get; set; }
        public bool Anulado { get; set; }
        public decimal? Credito { get; set; }
        public int? IdEncabezadoAcredita { get; set; }
        public string? Observaciones { get; set; }
        public decimal? CreditoCompartida { get; set; }
    }
}
