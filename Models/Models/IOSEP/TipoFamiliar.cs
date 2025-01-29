using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoFamiliar
    {
        public TipoFamiliar()
        {
            Afiliados = new HashSet<Afiliado>();
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
            Ddjjs = new HashSet<Ddjj>();
        }

        public byte IdTipoFamiliar { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo_Anses { get; set; }
        public bool? ConVencimiento { get; set; }
        public bool Anulado { get; set; }
        public string? compatible { get; set; }
        public bool? Iosep { get; set; }
        public bool? IosepSalud { get; set; }

        public virtual ICollection<Afiliado> Afiliados { get; set; }
        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
        public virtual ICollection<Ddjj> Ddjjs { get; set; }
    }
}
