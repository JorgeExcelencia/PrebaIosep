using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Discapacitado
    {
        public long IdDiscapacitados { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Discapacidad_Desde { get; set; }
        public DateTime Discapacidad_Hasta { get; set; }
        public string? Resolucion { get; set; }
        public string? Expediente { get; set; }
        public string? Observacion { get; set; }
        public bool Anulado { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
    }
}
