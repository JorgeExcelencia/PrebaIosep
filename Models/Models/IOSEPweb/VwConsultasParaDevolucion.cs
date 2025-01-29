using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwConsultasParaDevolucion
    {
        public int IdDetalleConsultas { get; set; }
        public int IdEncabezadoConsultas { get; set; }
        public string Matricula { get; set; } = null!;
        public string? NombrePrestador { get; set; }
        public DateTime FechaPractica { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string NombreAfiliado { get; set; } = null!;
        public decimal? Importe { get; set; }
        public decimal? Debitado { get; set; }
        public int? IdTipoDebito { get; set; }
        public string? CodigoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public bool Devolucion { get; set; }
        public string PeriodoDevolucion { get; set; } = null!;
        public bool Anulado { get; set; }
        public int DiagnosticosConsultasId { get; set; }
        public string? Codigo { get; set; }
        public string? Diagnostico { get; set; }
        public string PeriodoPresentacion { get; set; } = null!;
        public int IdInstitucion { get; set; }
        public int IdObraSocial { get; set; }
    }
}
