using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioSolicitudFacturacion
    {
        public SepelioSolicitudFacturacion()
        {
            SepelioSolicitudFacturacionDetalles = new HashSet<SepelioSolicitudFacturacionDetalle>();
        }

        public int SepelioSolicitudFacturacionID { get; set; }
        public int SepelioSolicitudID { get; set; }
        public string NumeroSolicitudFacturacion { get; set; } = null!;
        public string EstadoSolicitud { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public decimal ImporteTotal { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual SepelioSolicitud SepelioSolicitud { get; set; } = null!;
        public virtual ICollection<SepelioSolicitudFacturacionDetalle> SepelioSolicitudFacturacionDetalles { get; set; }
    }
}
