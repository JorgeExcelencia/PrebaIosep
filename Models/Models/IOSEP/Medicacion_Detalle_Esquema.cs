using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Medicacion_Detalle_Esquema
    {
        public int IdMedicacionDetalleEsquema { get; set; }
        public int? IdMedicacionEsquema { get; set; }
        public int IdEsquema { get; set; }
        public int IdPlan { get; set; }
        public int NroRegistro { get; set; }
        public int? NuevaDro { get; set; }
        public int? MultiDro { get; set; }
        public string? Presentacion { get; set; }
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public decimal? Cantidad { get; set; }
        public string TipoReconoce { get; set; } = null!;
        public decimal Reconoce { get; set; }
        public string? Resolucion { get; set; }
        public string? Ref_Resolucion { get; set; }
        public DateTime? InicioResol { get; set; }
        public DateTime? VencimientoResol { get; set; }
        public string? NroExpediente { get; set; }
        public string? Ref_Expediente { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Vencimiento { get; set; }
        public string? Observacion { get; set; }
        public byte? Edad_Minima { get; set; }
        public byte? Edad_Maxima { get; set; }
        public byte? IdSexo { get; set; }
        public bool Auditoria { get; set; }
        public decimal? Diario { get; set; }
        public decimal? Semanal { get; set; }
        public decimal? Mensual { get; set; }
        public decimal? Bimestral { get; set; }
        public decimal? Trimestral { get; set; }
        public decimal? Cuatrimestral { get; set; }
        public decimal? CincoMeses { get; set; }
        public decimal? Semestral { get; set; }
        public decimal? Anual { get; set; }
        public decimal? Vida { get; set; }
        public decimal? PorUnicaVez { get; set; }
        public decimal? Dias45 { get; set; }
        public byte? DiasCarencia { get; set; }
        public byte? DiasAutorizados { get; set; }
        public int? ProvistoPor { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionesAnula { get; set; }
        public DateTime? VencimientoAnterior { get; set; }
        public string? TipoFrecuenciaID { get; set; }
        public decimal? UID { get; set; }
    }
}
