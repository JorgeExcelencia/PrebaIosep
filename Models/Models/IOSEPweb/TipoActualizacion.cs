using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoActualizacion
    {
        public TipoActualizacion()
        {
            RegistroActualizacions = new HashSet<RegistroActualizacion>();
        }

        public int TipoActualizacionId { get; set; }
        public string DescripcionActualizacion { get; set; } = null!;

        public virtual ICollection<RegistroActualizacion> RegistroActualizacions { get; set; }
    }
}
