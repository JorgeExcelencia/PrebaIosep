using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogCantidadBonosAnulado
    {
        public int BonoAnuladoID { get; set; }
        public string TipoBono { get; set; } = null!;
        public int CantidadAnulados { get; set; }
        public DateTime FechaAnulacion { get; set; }
    }
}
