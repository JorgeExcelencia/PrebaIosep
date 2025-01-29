using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwPlanesNoGral_Sp
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public short ConsultasCantidad { get; set; }
        public decimal ConsultasReconoce { get; set; }
        public string ConsultasReconoceTipo { get; set; } = null!;
        public string FrecuenciaTipoConsulta { get; set; } = null!;
        public decimal ValOrdenCon { get; set; }
        public short FarmaciaCantidad { get; set; }
        public decimal FarmaciaReconoce { get; set; }
        public string FarmaciaReconoceTipo { get; set; } = null!;
        public string FrecuenciaTipoFarmacia { get; set; } = null!;
        public decimal ValOrdenFar { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public short? ConsultasVenceDias { get; set; }
        public short? FarmaciaVenceDias { get; set; }
        public int? IdCodigoconsulta { get; set; }
        public int? IdCodigomonodroga { get; set; }
    }
}
