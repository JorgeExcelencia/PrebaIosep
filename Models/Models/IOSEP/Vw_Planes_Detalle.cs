using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Planes_Detalle
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdPlan { get; set; }
        public int IdDetalle_Planes { get; set; }
    }
}
