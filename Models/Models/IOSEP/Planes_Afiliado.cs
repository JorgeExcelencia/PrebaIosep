using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Planes_Afiliado
    {
        public Planes_Afiliado()
        {
            PlanDiagnosticos = new HashSet<PlanDiagnostico>();
        }

        public int IdPlanes_Afiliado { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? FechaIngresoPlan { get; set; }
        public DateTime? FechaProbableParto { get; set; }
        public DateTime? FechaRenovacion { get; set; }
        public bool Anulado { get; set; }
        public string CreaOperador { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string AnulaOperador { get; set; } = null!;
        public DateTime AnulaFecha { get; set; }
        public int? IdPrestador { get; set; }
        public short? ConsultasCantidadTotal { get; set; }
        public int? ConsultaCantExtraOrd { get; set; }
        public short? ConsultasCantidad { get; set; }
        public decimal? ConsultasReconoce { get; set; }
        public string? ConsultasReconoceTipo { get; set; }
        public string? FrecuenciaTipoConsulta { get; set; }
        public short? ConsultasVenceDias { get; set; }
        public decimal? ValOrdenCon { get; set; }
        public short? FarmaciaCantidadTotal { get; set; }
        public int? FarmaciaCantExtraOrd { get; set; }
        public short? FarmaciaCantidad { get; set; }
        public decimal? FarmaciaReconoce { get; set; }
        public string? FarmaciaReconoceTipo { get; set; }
        public string? FrecuenciaTipoFarmacia { get; set; }
        public short? FarmaciaVenceDias { get; set; }
        public decimal? ValOrdenFar { get; set; }
        public string? Observaciones { get; set; }
        public int? ProvinciaID { get; set; }
        public int? EspecialidadID { get; set; }
        public int? DelegacionID { get; set; }
        public int? CentroMedico { get; set; }
        public int? TipoOperabilidadID { get; set; }
        public bool? Transporte { get; set; }
        public decimal? CoberturaTransporte { get; set; }
        public bool? Acompaniante { get; set; }
        public bool? Padres { get; set; }
        public int? CantAcompaniantes { get; set; }
        public int? TransporteID { get; set; }
        public int? IdAfiliadoRelacion { get; set; }
        public string? CUD { get; set; }
        public int? EscuelaId { get; set; }
        public int? TurnoId { get; set; }
        public int? NivelEscuelaId { get; set; }
        public int? MaestraId { get; set; }
        public int? TutorId { get; set; }
        public bool DigitalizaCUD { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionAnula { get; set; }
        public int? CantHorasAutorizadas { get; set; }
        public decimal? CantKilometros { get; set; }
        public DateTime? VencimientoAnterior { get; set; }
        public bool Codificado { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual Plane IdPlanNavigation { get; set; } = null!;
        public virtual ICollection<PlanDiagnostico> PlanDiagnosticos { get; set; }
    }
}
