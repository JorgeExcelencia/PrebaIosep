using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_DescuentoAporte
    {
        public Tipo_DescuentoAporte()
        {
            aportes = new HashSet<aporte>();
        }

        public string CodigoDescuentoID { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<aporte> aportes { get; set; }
    }
}
