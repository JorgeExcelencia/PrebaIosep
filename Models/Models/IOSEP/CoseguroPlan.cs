using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CoseguroPlan
    {
        public int CoseguroPlanID { get; set; }
        public int PlanID { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public bool Anulado { get; set; }
    }
}
