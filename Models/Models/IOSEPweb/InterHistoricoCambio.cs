using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterHistoricoCambio
    {
        public int IdHistoricoCambios { get; set; }
        public int IdDetalleProtocolo { get; set; }
        public string Codigo { get; set; } = null!;
        public string Practica { get; set; } = null!;
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
