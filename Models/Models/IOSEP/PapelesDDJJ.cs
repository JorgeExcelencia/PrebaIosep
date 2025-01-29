using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PapelesDDJJ
    {
        public int IdPapelesDDJJ { get; set; }
        public int IdPapel { get; set; }
        public int IdDdjj { get; set; }
        public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaRealizacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual AfiliadosDDJJ IdDdjjNavigation { get; set; } = null!;
        public virtual Papele IdPapelNavigation { get; set; } = null!;
    }
}
