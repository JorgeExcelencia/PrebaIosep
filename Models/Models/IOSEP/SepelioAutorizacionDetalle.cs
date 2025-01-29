using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioAutorizacionDetalle
    {
        public SepelioAutorizacionDetalle()
        {
            SepelioAutorizacionDetalleOrdens = new HashSet<SepelioAutorizacionDetalleOrden>();
        }

        public int SepelioAutorizacionDetalleID { get; set; }
        public int SepelioAutorizacionID { get; set; }
        public int SepelioServicioID { get; set; }
        public int SepelioServicioDetalleID { get; set; }
        public decimal Importe { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual SepelioAutorizacion SepelioAutorizacion { get; set; } = null!;
        public virtual SepelioServicio SepelioServicio { get; set; } = null!;
        public virtual SepelioServicioDetalle SepelioServicioDetalle { get; set; } = null!;
        public virtual ICollection<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdens { get; set; }
    }
}
