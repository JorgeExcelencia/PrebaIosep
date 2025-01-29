using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANCapitulo
    {
        public ANCapitulo()
        {
            ANCapituloSubcapitulos = new HashSet<ANCapituloSubcapitulo>();
            ANPracticasModulos = new HashSet<ANPracticasModulo>();
        }

        public int ANCapituloID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANCapituloSubcapitulo> ANCapituloSubcapitulos { get; set; }
        public virtual ICollection<ANPracticasModulo> ANPracticasModulos { get; set; }
    }
}
