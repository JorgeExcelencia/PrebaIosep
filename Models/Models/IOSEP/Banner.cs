using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Banner
    {
        public int IdBanner { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int CadaMinutos { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
