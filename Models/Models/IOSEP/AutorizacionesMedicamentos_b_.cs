using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AutorizacionesMedicamentos_b_
    {
        public int IdAutoriza { get; set; }
        public int? IdAfiliado { get; set; }
        public string Numero { get; set; } = null!;
        public int IdDelegacion { get; set; }
        public int? IdPrescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int? IdDiagnostico { get; set; }
        public int NroRegistro { get; set; }
        public byte? Cantidad { get; set; }
        public byte? CantidadSol { get; set; }
        public DateTime? Fecha_Prescripcion { get; set; }
        public DateTime? Fecha_Emision { get; set; }
        public DateTime? Fecha_Vence { get; set; }
        public string? Operador { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? Coseguro_Honorarios { get; set; }
        public decimal? Coseguro_Gastos { get; set; }
        public decimal? Reconoce_Honorarios { get; set; }
        public decimal? Reconoce_Gastos { get; set; }
        public decimal? Cobertura { get; set; }
        public string? Observacion { get; set; }
        public string? Motivo { get; set; }
        public byte TipoAutorizacion { get; set; }
        public byte? TipoId { get; set; }
        public int? IddeTipo { get; set; }
        public string? Autorizacion { get; set; }
        public short SeImprimio { get; set; }
        public bool Anulada { get; set; }
        public decimal Auditor_Porcentaje { get; set; }
        public byte EstadoAnulada { get; set; }
    }
}
