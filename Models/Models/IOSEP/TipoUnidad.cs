using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoUnidad
    {
        public TipoUnidad()
        {
            NomPracticaConvenioUnidads = new HashSet<NomPracticaConvenioUnidad>();
        }

        public int IdTipoUnidad { get; set; }
        public string Letra { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Valor { get; set; }
        public string HonGas { get; set; } = null!;

        public virtual ICollection<NomPracticaConvenioUnidad> NomPracticaConvenioUnidads { get; set; }
    }
}
