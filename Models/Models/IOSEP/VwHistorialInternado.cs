using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwHistorialInternado
    {
        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public string? Clinica { get; set; }
        public string? MedicoIngreso { get; set; }
        public string? MedicoIngresoNombre { get; set; }
        public string? MedicoAlta { get; set; }
        public string? MedicoAltaNombre { get; set; }
        public DateTime Fecha_Internacion { get; set; }
        public string? CodigoDiagnosticoIngreso { get; set; }
        public string? DiagnosticoIngreso { get; set; }
        public bool Hijo { get; set; }
        public bool Art { get; set; }
        public bool AccidenteTansito { get; set; }
        public string? Trata { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public string? CodigoDiagnosticoAlta { get; set; }
        public string? DiagnosticoAlta { get; set; }
        public bool Anulada { get; set; }
        public string? TipoInternacion { get; set; }
        public string? MotivoAlta { get; set; }
    }
}
