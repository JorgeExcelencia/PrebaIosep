using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AutorizacionSepelios_Encabezado
    {
        public AutorizacionSepelios_Encabezado()
        {
            AutorizacionSepelios_Detalles = new HashSet<AutorizacionSepelios_Detalle>();
        }

        public int IdAutorizacionSepelios { get; set; }
        public int IdAfiliado { get; set; }
        public string Numero { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime Fecha_Fallecimiento { get; set; }
        public string Nro_Acta { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual ICollection<AutorizacionSepelios_Detalle> AutorizacionSepelios_Detalles { get; set; }
    }
}
