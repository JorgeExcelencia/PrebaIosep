using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ConEncabezadoPresentacion
    {
        public int IdEncabezadoConsultas { get; set; }
        public DateTime Fecha { get; set; }
        public string PeriodoPresentacion { get; set; } = null!;
        public int IdObraSocial { get; set; }
        public int IdInstitucion { get; set; }
        public DateTime? FechaCierrePresentacion { get; set; }
        public string? OperadorCierrePresentacion { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OperadorCierreAuditoria { get; set; }
        public DateTime? FechaCierreCompartida { get; set; }
        public string? OperadorCierreCompartida { get; set; }
        public byte Complementaria { get; set; }
        public bool Anulado { get; set; }
        public string? NumeroFactura { get; set; }
        public bool Anuladas { get; set; }
    }
}
