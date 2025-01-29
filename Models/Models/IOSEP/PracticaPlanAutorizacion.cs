using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PracticaPlanAutorizacion
    {
        public int PracticaPlanAutorizacionID { get; set; }
        public int PracticaBaseID { get; set; }
        public int PlanID { get; set; }
        public string DescripcionCobertura { get; set; } = null!;
        public int DetalleAutorizacionID { get; set; }
        public int? DiagnosticoID { get; set; }
    }
}
