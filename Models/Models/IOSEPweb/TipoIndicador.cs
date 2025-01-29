using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoIndicador
    {
        public TipoIndicador()
        {
            Indicadores = new HashSet<Indicadore>();
        }

        public int IdTipoIndicador { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Indicadore> Indicadores { get; set; }
    }
}
