using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoEntidad
    {
        public TipoEntidad()
        {
            RegistroActualizacions = new HashSet<RegistroActualizacion>();
        }

        public int TipoEntidadId { get; set; }
        public string DescripcionEntidad { get; set; } = null!;

        public virtual ICollection<RegistroActualizacion> RegistroActualizacions { get; set; }
    }
}
