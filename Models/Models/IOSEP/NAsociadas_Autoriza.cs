using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NAsociadas_Autoriza
    {
        public int IdAsociadas_Autoriza { get; set; }
        public int IdNNomenclador { get; set; }
        public decimal cantidad { get; set; }
        public decimal Importe { get; set; }
        public bool Anulado { get; set; }
    }
}
