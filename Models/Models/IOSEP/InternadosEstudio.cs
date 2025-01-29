using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosEstudio
    {
        public int IdHistoria { get; set; }
        public int IdInternado { get; set; }
        public DateTime Fecha { get; set; }
        public string? Antecedentes { get; set; }
        public string? ExamenFisico { get; set; }
        public string? Estudios { get; set; }
        public string? Diagnostico { get; set; }
        public string? Motivo { get; set; }
        public string? Modificaria { get; set; }
        public int IdMedico { get; set; }
        public string? Longitud { get; set; }
        public string? Latitud { get; set; }
        public bool Anulado { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
    }
}
