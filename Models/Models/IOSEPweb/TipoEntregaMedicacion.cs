using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoEntregaMedicacion
    {
        public TipoEntregaMedicacion()
        {
            FarEntregaMedicacionPendientes = new HashSet<FarEntregaMedicacionPendiente>();
            FarEntregaMedicacions = new HashSet<FarEntregaMedicacion>();
            FarVentaPendientes = new HashSet<FarVentaPendiente>();
        }

        public int TipoEntregaMedicacionId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<FarEntregaMedicacionPendiente> FarEntregaMedicacionPendientes { get; set; }
        public virtual ICollection<FarEntregaMedicacion> FarEntregaMedicacions { get; set; }
        public virtual ICollection<FarVentaPendiente> FarVentaPendientes { get; set; }
    }
}
