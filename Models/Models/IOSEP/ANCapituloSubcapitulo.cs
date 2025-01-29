using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANCapituloSubcapitulo
    {
        public ANCapituloSubcapitulo()
        {
            ANPracticasModulos = new HashSet<ANPracticasModulo>();
        }

        public int ANCapituloSubcapituloID { get; set; }
        public int ANCapituloID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ANCapitulo ANCapitulo { get; set; } = null!;
        public virtual ICollection<ANPracticasModulo> ANPracticasModulos { get; set; }
    }
}
