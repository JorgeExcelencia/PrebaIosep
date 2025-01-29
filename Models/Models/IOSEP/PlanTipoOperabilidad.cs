using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanTipoOperabilidad
    {
        public int PlanTipoOperabilidadID { get; set; }
        public int IdAfiliado { get; set; }
        public int? IdPlanes_Afiliado { get; set; }
        public int IdPlan { get; set; }
        public int? CartaPresentacionId { get; set; }
        public int TipoOperabilidadID { get; set; }
        public int TipoOperabilidadAfiliadoID { get; set; }
        public int? EsquemaID { get; set; }
        public DateTime FechaCarga { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
