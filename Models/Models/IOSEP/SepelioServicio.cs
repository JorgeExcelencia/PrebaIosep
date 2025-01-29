using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioServicio
    {
        public SepelioServicio()
        {
            SepelioAutorizacionDetalles = new HashSet<SepelioAutorizacionDetalle>();
            SepelioServicioDetalles = new HashSet<SepelioServicioDetalle>();
            SepelioSolicitudFacturacionDetalles = new HashSet<SepelioSolicitudFacturacionDetalle>();
        }

        public int SepelioServicioID { get; set; }
        public string NombreServicio { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<SepelioAutorizacionDetalle> SepelioAutorizacionDetalles { get; set; }
        public virtual ICollection<SepelioServicioDetalle> SepelioServicioDetalles { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalle> SepelioSolicitudFacturacionDetalles { get; set; }
    }
}
