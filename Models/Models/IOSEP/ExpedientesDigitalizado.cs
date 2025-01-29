using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ExpedientesDigitalizado
    {
        public int ExpedienteDigitalizadoId { get; set; }
        public int ExpedienteId { get; set; }
        public string NumeroExpediente { get; set; } = null!;
        public string RefExpediente { get; set; } = null!;
        public DateTime FechaExpediente { get; set; }
        public string NombreIniciador { get; set; } = null!;
        public string CuilIniciador { get; set; } = null!;
        public string? SectorIniciador { get; set; }
        public int SectorCargaId { get; set; }
        public bool Digitalizado { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionAnula { get; set; }
    }
}
