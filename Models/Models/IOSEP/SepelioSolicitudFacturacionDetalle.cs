using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioSolicitudFacturacionDetalle
    {
        public SepelioSolicitudFacturacionDetalle()
        {
            SepelioSolicitudFacturacionDetalleDetalles = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
        }

        public int SepelioSolicitudFacturacionDetalleID { get; set; }
        public int SepelioSolicitudFacturacionID { get; set; }
        public int SepelioServicioID { get; set; }
        public decimal Importe { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual SepelioServicio SepelioServicio { get; set; } = null!;
        public virtual SepelioSolicitudFacturacion SepelioSolicitudFacturacion { get; set; } = null!;
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalles { get; set; }
    }
}
