using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Plane
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Resolucion { get; set; } = null!;
        public short ConsultasCantidad { get; set; }
        public decimal ConsultasReconoce { get; set; }
        public short FarmaciaCantidad { get; set; }
        public decimal FarmaciaReconoce { get; set; }
        public string Observaciones { get; set; } = null!;
        public string ConsultasReconoceTipo { get; set; } = null!;
        public string FarmaciaReconoceTipo { get; set; } = null!;
        public string FrecuenciaTipoConsulta { get; set; } = null!;
        public string FrecuenciaTipoFarmacia { get; set; } = null!;
    }
}
