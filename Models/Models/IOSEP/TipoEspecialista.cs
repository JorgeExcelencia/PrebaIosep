using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoEspecialista
    {
        public TipoEspecialista()
        {
            InternadosQuirofanoDetalles = new HashSet<InternadosQuirofanoDetalle>();
        }

        public int EspecialistaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<InternadosQuirofanoDetalle> InternadosQuirofanoDetalles { get; set; }
    }
}
