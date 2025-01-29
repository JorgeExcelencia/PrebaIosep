using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PapelesDigitalizadosDDJJ
    {
        public int IdPapelDigitalizado { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdDdjj { get; set; }
        public bool Anulado { get; set; }
    }
}
