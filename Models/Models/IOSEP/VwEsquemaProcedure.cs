using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwEsquemaProcedure
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public short ConsultasCantidad { get; set; }
        public decimal ConsultasReconoce { get; set; }
        public string ConsultasReconoceTipo { get; set; } = null!;
        public short FarmaciaCantidad { get; set; }
        public decimal FarmaciaReconoce { get; set; }
        public string FarmaciaReconoceTipo { get; set; } = null!;
        public bool Anulado { get; set; }
        public int IdEsquema { get; set; }
        public string FrecuenciaTipoConsulta { get; set; } = null!;
        public string FrecuenciaTipoFarmacia { get; set; } = null!;
        public decimal ValOrdenCon { get; set; }
        public decimal ValOrdenFar { get; set; }
        public bool Anula { get; set; }
    }
}
