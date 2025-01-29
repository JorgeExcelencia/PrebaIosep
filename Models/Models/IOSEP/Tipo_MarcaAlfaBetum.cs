using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_MarcaAlfaBetum
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
