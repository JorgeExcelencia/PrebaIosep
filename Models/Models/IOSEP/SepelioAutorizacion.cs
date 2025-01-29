using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioAutorizacion
    {
        public SepelioAutorizacion()
        {
            SepelioAutorizacionDetalleSolicitudes = new HashSet<SepelioAutorizacionDetalleSolicitude>();
            SepelioAutorizacionDetalles = new HashSet<SepelioAutorizacionDetalle>();
        }

        public int SepelioAutorizacionID { get; set; }
        public int SepelioSolicitudID { get; set; }
        public string NumeroAutorizacion { get; set; } = null!;
        public DateTime FechaAutorizacion { get; set; }
        public decimal ImporteAutorizado { get; set; }
        public bool AutorizaSolicitudPrestador { get; set; }
        public string Tipo { get; set; } = null!;
        public string? ObservacionesSociales { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual SepelioSolicitud SepelioSolicitud { get; set; } = null!;
        public virtual ICollection<SepelioAutorizacionDetalleSolicitude> SepelioAutorizacionDetalleSolicitudes { get; set; }
        public virtual ICollection<SepelioAutorizacionDetalle> SepelioAutorizacionDetalles { get; set; }
    }
}
