using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoInternacionPractica
    {
        public int IdTipoInternacionPractica { get; set; }
        public int IdTipoInternacion { get; set; }
        public int IdPractica { get; set; }
        public short Cantidad { get; set; }
        public bool Anulado { get; set; }
    }
}
