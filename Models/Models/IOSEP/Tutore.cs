using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tutore
    {
        public int TutorId { get; set; }
        public string NumDocumento { get; set; } = null!;
        public string CUIL { get; set; } = null!;
        public string NombreApellido { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public byte? IdSexo { get; set; }
        public string? Domicilio { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? TelefonoCelular { get; set; }
        public int? IdLocalidad { get; set; }
        public int? IdProvincia { get; set; }
        public string? Observaciones { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? IdMotivo { get; set; }
    }
}
