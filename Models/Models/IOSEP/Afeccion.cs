using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Afeccion
    {
        public Afeccion()
        {
            InternadosAfeccions = new HashSet<InternadosAfeccion>();
        }

        public int IdAfeccion { get; set; }
        public string? Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<InternadosAfeccion> InternadosAfeccions { get; set; }
    }
}
