using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosQuirofano
    {
        public InternadosQuirofano()
        {
            InternadosQuirofanoDetalles = new HashSet<InternadosQuirofanoDetalle>();
        }

        public int QuirofanoID { get; set; }
        public int IdInternado { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Observacion { get; set; }
        public string? OpCrea { get; set; }
        public DateTime FecCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FecModi { get; set; }
        public bool Anulado { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
        public virtual ICollection<InternadosQuirofanoDetalle> InternadosQuirofanoDetalles { get; set; }
    }
}
