using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorHabilitacion
    {
        public int PrestadorHabilitacionID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}
