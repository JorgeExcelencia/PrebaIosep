using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioServicioDetalle
    {
        public SepelioServicioDetalle()
        {
            SepelioAutorizacionDetalles = new HashSet<SepelioAutorizacionDetalle>();
            SepelioSolicitudFacturacionDetalleDetalles = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
        }

        public int SepelioServicioDetalleID { get; set; }
        public int SepelioServicioID { get; set; }
        public string NombreDetalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual SepelioServicio SepelioServicio { get; set; } = null!;
        public virtual ICollection<SepelioAutorizacionDetalle> SepelioAutorizacionDetalles { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalles { get; set; }
    }
}
