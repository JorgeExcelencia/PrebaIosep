using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInfoInternadopAutMed
    {
        public string Numero { get; set; } = null!;
        public int IdInternado { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Fecha_Internacion { get; set; }
        public string Diagnostico { get; set; } = null!;
        public string TipoInternacion { get; set; } = null!;
        public string? Tratamiento { get; set; }
        public string Sector { get; set; } = null!;
        public DateTime? Fecha_Alta { get; set; }
        public string Codigo { get; set; } = null!;
        public int IdAfiliado { get; set; }
    }
}
