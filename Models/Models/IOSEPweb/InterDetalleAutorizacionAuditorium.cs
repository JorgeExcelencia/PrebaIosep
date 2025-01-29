using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterDetalleAutorizacionAuditorium
    {
        public int IdDetalleAutorizacionAuditoria { get; set; }
        public int IdDetalleAutorizacion { get; set; }
        public int IdPractica { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public byte CantidadAutorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal? FacturaHonorarios { get; set; }
        public decimal? FacturaGastos { get; set; }
        public int IdTipoDebitoHonorarios { get; set; }
        public int IdTipoDebitoGastos { get; set; }
        public decimal DebitoHonorarios { get; set; }
        public decimal DebitoGastos { get; set; }
        public decimal CreditoHonorarios { get; set; }
        public decimal CreditoGastos { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? Observaciones { get; set; }
    }
}
