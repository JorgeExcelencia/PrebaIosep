using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Paise
    {
        public Paise()
        {
            Afiliados = new HashSet<Afiliado>();
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
            Ddjjs = new HashSet<Ddjj>();
            Provincia = new HashSet<Provincia>();
        }

        public int IdPais { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Nacionalidad { get; set; }
        public short? Anses { get; set; }
        public bool Anulado { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<Afiliado> Afiliados { get; set; }
        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
        public virtual ICollection<Ddjj> Ddjjs { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
