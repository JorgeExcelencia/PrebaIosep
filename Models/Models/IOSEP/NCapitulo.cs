using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NCapitulo
    {
        public int IdCapitulo { get; set; }
        public string? Nombre { get; set; }
        public string? Observaciones { get; set; }
        public bool? Anulado { get; set; }
    }
}
