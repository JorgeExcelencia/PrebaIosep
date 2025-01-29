using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Practicas_esquema
    {
        public int IdPracticasEsquemas { get; set; }
        public int IdEsquema { get; set; }
        public int IdNomenclador { get; set; }
        public string? Descripcion { get; set; }
        public int IdDetallePlan { get; set; }
        public int? IdPlan { get; set; }
        public string ReconoceTipo { get; set; } = null!;
        public string? Resolucion { get; set; }
        public string? Ref_Resolucion { get; set; }
        public DateTime? InicioResol { get; set; }
        public DateTime? VencimientoResol { get; set; }
        public string? NroExpediente { get; set; }
        public string? Ref_Expediente { get; set; }
        public decimal Reconoce { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Vencimiento { get; set; }
        public byte? Edad_Minima { get; set; }
        public byte? Edad_Maxima { get; set; }
        public bool Informa { get; set; }
        public byte? IdSexo { get; set; }
        public bool Auditoria { get; set; }
        public byte? Diario { get; set; }
        public byte? Semanal { get; set; }
        public byte? Mensual { get; set; }
        public byte? Bimestral { get; set; }
        public byte? Trimestral { get; set; }
        public byte? Cuatrimestral { get; set; }
        public byte? CincoMeses { get; set; }
        public byte? Semestral { get; set; }
        public byte? Anual { get; set; }
        public byte? Vida { get; set; }
        public byte? PorUnicaVez { get; set; }
        public short? DiasCarencia { get; set; }
        public short? DiasAutorizados { get; set; }
        public int ViaID { get; set; }
        public string? Observaciones { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionesAnula { get; set; }
        public int? Cantidad { get; set; }
        public string? TipoFrecuenciaID { get; set; }

        public virtual Esquemas_Afiliado IdEsquemaNavigation { get; set; } = null!;
    }
}
