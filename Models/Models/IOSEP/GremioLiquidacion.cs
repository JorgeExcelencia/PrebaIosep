using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GremioLiquidacion
    {
        public int IdGremioLiquidacion { get; set; }
        public int IdGremio { get; set; }
        public int IdInternado { get; set; }
        public string EstadoInternacion { get; set; } = null!;
        public decimal ImporteSolicitadoOS { get; set; }
        public decimal ImporteAuditadoGremio { get; set; }
        public int CantidadCuotas { get; set; }
        public string? MotivoDebito { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
