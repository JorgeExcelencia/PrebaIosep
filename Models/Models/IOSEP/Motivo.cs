using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Motivo
    {
        public int IdMotivo { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulacion { get; set; }
        public bool Supervisor { get; set; }
        public bool Farmacia { get; set; }
        public bool Reintegros { get; set; }
        public bool Rechazo { get; set; }
        public bool Internados { get; set; }
        public bool Imagenes { get; set; }
        public bool Aleatorio { get; set; }
        public bool Planes { get; set; }
        public bool Tesoreria { get; set; }
        public bool Asesoria { get; set; }
        public bool ControlCalidad { get; set; }
        public bool OnLine { get; set; }
        public bool Expedientes { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? MotivoAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
    }
}
