using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EsquemaDiasCobertura
    {
        public int EsquemaDiasCoberturaID { get; set; }
        public int IdEsquema { get; set; }
        public int IdPlan { get; set; }
        public int DesdeDia { get; set; }
        public int HastaDia { get; set; }
        public int CantidadDias { get; set; }
        public int Cobertura { get; set; }
        public int? MotivoModCobID { get; set; }
        public string? NroResolucion { get; set; }
        public string? RefResolucion { get; set; }
        public string? NroExpediente { get; set; }
        public string? RefExpediente { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? MotivoAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
