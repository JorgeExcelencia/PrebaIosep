using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_SituacionLaboral
    {
        public Tipo_SituacionLaboral()
        {
            LugarPagoDDJJs = new HashSet<LugarPagoDDJJ>();
        }

        public int IdSituacionLaboral { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<LugarPagoDDJJ> LugarPagoDDJJs { get; set; }
    }
}
