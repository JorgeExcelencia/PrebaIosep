using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentroRubroPrestador
    {
        public int IdCentroRubroPrestador { get; set; }
        public int IdCentroDeImagen { get; set; }
        public int IdPrestador { get; set; }
        public bool Anulado { get; set; }
    }
}
