using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoSolicitud
    {
        public ANTipoSolicitud()
        {
            ANSolicitudCambios = new HashSet<ANSolicitudCambio>();
        }

        public int ANTipoSolicitudID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Abreviatura { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANSolicitudCambio> ANSolicitudCambios { get; set; }
    }
}
