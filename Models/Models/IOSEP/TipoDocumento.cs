using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Afiliados = new HashSet<Afiliado>();
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
            Ddjjs = new HashSet<Ddjj>();
        }

        public byte IdTipoDocumento { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo_Anses { get; set; }
        public bool Anulado { get; set; }
        public string? Codigo { get; set; }
        public int? IdNovedades { get; set; }

        public virtual ICollection<Afiliado> Afiliados { get; set; }
        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
        public virtual ICollection<Ddjj> Ddjjs { get; set; }
    }
}
