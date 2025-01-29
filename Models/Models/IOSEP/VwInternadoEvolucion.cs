using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternadoEvolucion
    {
        public int idinternado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Clinica { get; set; }
        public string? matricula { get; set; }
        public string? Prestador { get; set; }
        public string? matriculaalta { get; set; }
        public string? PrestadorAlta { get; set; }
        public string? MotivoAlta { get; set; }
        public string? TipoInternacion { get; set; }
        public string? Derivado_a { get; set; }
        public DateTime fecha_internacion { get; set; }
        public string Diagnostico { get; set; } = null!;
        public DateTime? fecha_alta { get; set; }
        public string? TratamientoAlta { get; set; }
        public string? tratamiento { get; set; }
        public string? Sector { get; set; }
        public int IdAfiliado { get; set; }
    }
}
