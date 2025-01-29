using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiAtsa
    {
        public int IdAfiAtsa { get; set; }
        public string Entidad { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
