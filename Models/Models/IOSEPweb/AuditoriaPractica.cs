using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AuditoriaPractica
    {
        public int IdAuditoria { get; set; }
        public int IdDetalleOrden { get; set; }
        public int IdPractica { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public int? IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public decimal? Credito { get; set; }
        public string? Observaciones { get; set; }
        public decimal? CreditoPendiente { get; set; }
        public int? EncabezadoIdacredita { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
