using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoServicio_Sepelio
    {
        public TipoServicio_Sepelio()
        {
            AutorizacionSepelios_Detalles = new HashSet<AutorizacionSepelios_Detalle>();
        }

        public int IdTipoServicioSepelios { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<AutorizacionSepelios_Detalle> AutorizacionSepelios_Detalles { get; set; }
    }
}
