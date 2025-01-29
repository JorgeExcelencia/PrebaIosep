using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoCarencium
    {
        public byte IdTipoCarencia { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? ConPractica { get; set; }
        public bool? Anulado { get; set; }
    }
}
