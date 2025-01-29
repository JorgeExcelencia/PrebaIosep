using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Papele
    {
        public Papele()
        {
            CategoriaPapeles = new HashSet<CategoriaPapele>();
            PapelesDDJJs = new HashSet<PapelesDDJJ>();
        }

        public int IdPapel { get; set; }
        public string Nombre { get; set; } = null!;
        public int? VigenciaDias { get; set; }
        public string? PeriodoVence { get; set; }
        public string? PeriodoVence2 { get; set; }
        public int? VencimientoDias { get; set; }
        public bool Afiliacion { get; set; }
        public bool Estudios { get; set; }
        public bool IosepSalud { get; set; }
        public bool Iosep { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<CategoriaPapele> CategoriaPapeles { get; set; }
        public virtual ICollection<PapelesDDJJ> PapelesDDJJs { get; set; }
    }
}
