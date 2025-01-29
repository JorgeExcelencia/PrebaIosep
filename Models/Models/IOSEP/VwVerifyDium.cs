using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwVerifyDium
    {
        public DateTime DiaHora { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string Titular { get; set; } = null!;
        public short idestado { get; set; }
        public short Anulada { get; set; }
        public bool EsAlta { get; set; }
        public int idinternado { get; set; }
    }
}
