using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwDiaInternado
    {
        public int idinternado { get; set; }
        public int idafiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public long IdDiaInternado { get; set; }
        public DateTime DiaHora { get; set; }
        public bool EsAlta { get; set; }
        public DateTime? DiaHora_Anterior { get; set; }
        public short idestado { get; set; }
    }
}
