using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ConDetallePresentacion
    {
        public int IdDetalleConsultas { get; set; }
        public int IdEncabezadoConsultas { get; set; }
        public int? IdPrestador { get; set; }
        public int? IdPrestadorLiquida { get; set; }
        public DateTime FechaPractica { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public int IdNomenclador { get; set; }
        public int IdAfiliado { get; set; }
        public decimal? Importe { get; set; }
        public int? IdDiagnostico { get; set; }
        public decimal? Debitado { get; set; }
        public int? IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal Credito { get; set; }
        public bool ACompartida { get; set; }
        public int IdEncabezadoAcredita { get; set; }
        public decimal CreditoCompartida { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string? OperadorCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public bool Devolucion { get; set; }
        public string PeriodoDevolucion { get; set; } = null!;
        public bool Refacturable { get; set; }
        public bool? Chequeado { get; set; }
        public bool? SugiereDebito { get; set; }
    }
}
