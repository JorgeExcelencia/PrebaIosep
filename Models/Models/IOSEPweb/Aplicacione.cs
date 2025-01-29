using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Aplicacione
    {
        public int IdAplicaciones { get; set; }
        public string Nombre { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
