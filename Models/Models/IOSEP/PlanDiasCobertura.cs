using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanDiasCobertura
    {
        public int PlanDiasCoberturaID { get; set; }
        public int? IdDetalle_Planes { get; set; }
        public int IdPlan { get; set; }
        public int DesdeDia { get; set; }
        public int HastaDia { get; set; }
        public int CantidadDias { get; set; }
        public decimal Cobertura { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
