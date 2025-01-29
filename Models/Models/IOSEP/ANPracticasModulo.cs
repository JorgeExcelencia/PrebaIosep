using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANPracticasModulo
    {
        public ANPracticasModulo()
        {
            ANConvenioPracticas = new HashSet<ANConvenioPractica>();
        }

        public int ANPracticaModuloID { get; set; }
        public int ANCapituloID { get; set; }
        public int ANCapituloSubcapituloID { get; set; }
        public int ANPracticaBaseID { get; set; }
        public bool Anulado { get; set; }

        public virtual ANCapitulo ANCapitulo { get; set; } = null!;
        public virtual ANCapituloSubcapitulo ANCapituloSubcapitulo { get; set; } = null!;
        public virtual ANPracticasBase ANPracticaBase { get; set; } = null!;
        public virtual ICollection<ANConvenioPractica> ANConvenioPracticas { get; set; }
    }
}
