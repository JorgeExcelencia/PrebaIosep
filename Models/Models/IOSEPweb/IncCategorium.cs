using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncCategorium
    {
        public IncCategorium()
        {
            IncEstados = new HashSet<IncEstado>();
        }

        public int CategoriaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Color { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<IncEstado> IncEstados { get; set; }
    }
}
