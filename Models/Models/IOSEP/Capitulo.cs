using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Capitulo
    {
        public byte Capitulo1 { get; set; }
        public string Nombre { get; set; } = null!;
        public string Desde { get; set; } = null!;
        public string Hasta { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
