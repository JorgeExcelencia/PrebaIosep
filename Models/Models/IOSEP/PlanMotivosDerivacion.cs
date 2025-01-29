using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanMotivosDerivacion
    {
        public int PlanMotivosDerivacionID { get; set; }
        public int IdAfiliado { get; set; }
        public int? IdPlanes_Afiliado { get; set; }
        public int IdPlan { get; set; }
        public int? CartaPresentacionID { get; set; }
        public int MotivoDerivacionID { get; set; }
        public int? EsquemaID { get; set; }
        public DateTime FechaCarga { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
