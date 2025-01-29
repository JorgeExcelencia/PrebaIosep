using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AutorizacionSepelios_Detalle
    {
        public int IdAutorizacionSepeliosDetalle { get; set; }
        public int IdAutorizacionSepelios { get; set; }
        public int IdTipoServicioSepelios { get; set; }
        public string Empresa { get; set; } = null!;
        public string? Traslado_Desde { get; set; }
        public string? Traslado_Hasta { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual AutorizacionSepelios_Encabezado IdAutorizacionSepeliosNavigation { get; set; } = null!;
        public virtual TipoServicio_Sepelio IdTipoServicioSepeliosNavigation { get; set; } = null!;
    }
}
