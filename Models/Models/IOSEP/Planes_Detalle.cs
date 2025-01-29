using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Planes_Detalle
    {
        public Planes_Detalle()
        {
            Medicacion_planes = new HashSet<Medicacion_plane>();
            Practicas_planes = new HashSet<Practicas_plane>();
        }

        public int IdDetalle_Planes { get; set; }
        public int IdPlan { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string? Resolucion { get; set; }
        public string? RefResolucion { get; set; }
        public short ConsultasCantidad { get; set; }
        public decimal ConsultasReconoce { get; set; }
        public string ConsultasReconoceTipo { get; set; } = null!;
        /// <summary>
        /// S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual
        /// </summary>
        public string FrecuenciaTipoConsulta { get; set; } = null!;
        public short? ConsultasVenceDias { get; set; }
        public decimal ValOrdenCon { get; set; }
        public short FarmaciaCantidad { get; set; }
        public decimal FarmaciaReconoce { get; set; }
        public string FarmaciaReconoceTipo { get; set; } = null!;
        /// <summary>
        /// S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual
        /// </summary>
        public string FrecuenciaTipoFarmacia { get; set; } = null!;
        public short? FarmaciaVenceDias { get; set; }
        public decimal ValOrdenFar { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public int Frecuencia { get; set; }
        /// <summary>
        /// S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual
        /// </summary>
        public string FrecuenciaTipo { get; set; } = null!;
        public string CreaOperador { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string AnulaOperador { get; set; } = null!;
        public DateTime? AnulaFecha { get; set; }
        public int? IdCodigoconsulta { get; set; }
        public int? IdCodigomonodroga { get; set; }

        public virtual Plane IdPlanNavigation { get; set; } = null!;
        public virtual ICollection<Medicacion_plane> Medicacion_planes { get; set; }
        public virtual ICollection<Practicas_plane> Practicas_planes { get; set; }
    }
}
