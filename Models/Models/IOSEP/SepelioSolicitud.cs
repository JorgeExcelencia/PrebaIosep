using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioSolicitud
    {
        public SepelioSolicitud()
        {
            SepelioAutorizacions = new HashSet<SepelioAutorizacion>();
            SepelioSolicitudFacturacions = new HashSet<SepelioSolicitudFacturacion>();
        }

        public int SepelioSolicitudID { get; set; }
        public int AfiliadoID { get; set; }
        public int? PrestadorID { get; set; }
        public string NumeroSolicitud { get; set; } = null!;
        public string EstadoSolicitud { get; set; } = null!;
        public DateTime FechaFallecimiento { get; set; }
        public DateTime FechaDenunciaFallecimiento { get; set; }
        public DateTime? FechaRecepcionAfiliaciones { get; set; }
        public string? Observaciones { get; set; }
        public string? ObservacionesAfiliaciones { get; set; }
        public bool EmiteAfiliaciones { get; set; }
        public bool SolicitudFacturacion { get; set; }
        public string? NumeroActa { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual Afiliado Afiliado { get; set; } = null!;
        public virtual Prestadore? Prestador { get; set; }
        public virtual ICollection<SepelioAutorizacion> SepelioAutorizacions { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacion> SepelioSolicitudFacturacions { get; set; }
    }
}
