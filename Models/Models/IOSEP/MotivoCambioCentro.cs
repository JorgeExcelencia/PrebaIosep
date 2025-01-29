using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoCambioCentro
    {
        public int MotivoCambioCentroID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
        public bool? Aleatorio { get; set; }
    }
}
