using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RectificarPase
    {
        public int RectificaPaseID { get; set; }
        public int ReintegrosEncabezoID { get; set; }
        public int ReintegroSectoresID { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
