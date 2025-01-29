using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Escuela
    {
        public int EscuelaId { get; set; }
        public string CodEscuela { get; set; } = null!;
        public string NombreEscuela { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? IdProvincia { get; set; }
        public int? IdLocalidad { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? TelefonoCelular { get; set; }
        public int NivelEscuelaId { get; set; }
        public string? Director { get; set; }
        public string? Observaciones { get; set; }
        public string OperCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? OperMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? IdMotivo { get; set; }
        public bool Anulado { get; set; }

        public virtual NivelEscuela NivelEscuela { get; set; } = null!;
    }
}
