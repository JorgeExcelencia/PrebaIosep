using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Medicacion_Detalle_Plane
    {
        public int IdMedicacionDetallePlanes { get; set; }
        public int? IdMedicacionPlan { get; set; }
        public int IdPlan { get; set; }
        public int? IdArticulo { get; set; }
        public int? NroRegistro { get; set; }
        public int? NuevaDro { get; set; }
        public int? MultiDro { get; set; }
        public string? Presentacion { get; set; }
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public string? Troquel { get; set; }
        public decimal? Cantidad { get; set; }
        public string? TipoReconoce { get; set; }
        public decimal? Reconoce { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Vencimiento { get; set; }
        public string? NroResolucion { get; set; }
        public string? RefResolucion { get; set; }
        public string? NroExpediente { get; set; }
        public string? RefExpediente { get; set; }
        public DateTime? InicioResol { get; set; }
        public DateTime? VencimientoResol { get; set; }
        public byte? Edad_Minima { get; set; }
        public byte? Edad_Maxima { get; set; }
        public byte? IdSexo { get; set; }
        public bool? Auditoria { get; set; }
        public byte? Diario { get; set; }
        public byte? Mensual { get; set; }
        public byte? Bimestral { get; set; }
        public byte? Trimestral { get; set; }
        public byte? Cuatrimestral { get; set; }
        public byte? CincoMeses { get; set; }
        public byte? Semestral { get; set; }
        public byte? Anual { get; set; }
        public byte? PorUnicaVez { get; set; }
        public byte? Vida { get; set; }
        public byte? DiasCarencia { get; set; }
        public byte? DiasAutorizados { get; set; }
        public int? ProvistoPor { get; set; }
        public string? Observaciones { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }
    }
}
