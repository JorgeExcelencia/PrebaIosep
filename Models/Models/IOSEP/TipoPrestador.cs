using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoPrestador
    {
        public TipoPrestador()
        {
            Prestadores = new HashSet<Prestadore>();
        }

        public short TipoPrestadorID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Prestadore> Prestadores { get; set; }
    }
}
