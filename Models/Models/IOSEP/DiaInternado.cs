using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DiaInternado
    {
        public long IdDiaInternado { get; set; }
        public int IdInternado { get; set; }
        public DateTime DiaHora { get; set; }
        public string Tarjeta { get; set; } = null!;
        public bool EsAlta { get; set; }
        public DateTime? DiaHora_Anterior { get; set; }
        public short Anulada { get; set; }
    }
}
