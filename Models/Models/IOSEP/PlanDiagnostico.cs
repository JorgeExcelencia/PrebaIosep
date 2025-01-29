using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanDiagnostico
    {
        public int PlanDiagnosticoID { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdPlanes_Afiliado { get; set; }
        public int? CartaPresentacionID { get; set; }
        public int DiagnosticoID { get; set; }
        public int? IdPlan { get; set; }
        public int? EsquemaID { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }

        public virtual Planes_Afiliado? IdPlanes_AfiliadoNavigation { get; set; }
    }
}
