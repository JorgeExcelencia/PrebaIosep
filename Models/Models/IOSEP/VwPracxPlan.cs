using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwPracxPlan
    {
        public int IdEsquema { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public bool AnuladoEsquema { get; set; }
        public int IdPlan { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public bool AnuladoPlanEsquema { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool AnuladoPlan { get; set; }
        public int IdNomenclador { get; set; }
        public int Cantidad { get; set; }
        public string Practica { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public bool AnuladoPracticasPlan { get; set; }
        public bool AnuladoNomenclador { get; set; }
        public string NombrePlan { get; set; } = null!;
    }
}
