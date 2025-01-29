using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoUnidad
    {
        public ANTipoUnidad()
        {
            ANPracticasBases = new HashSet<ANPracticasBase>();
        }

        public int ANTipoUnidadID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Abreviatura { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANPracticasBase> ANPracticasBases { get; set; }
    }
}
