using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NTipo_Calculo
    {
        public NTipo_Calculo()
        {
            NNomenclador_Bases = new HashSet<NNomenclador_Base>();
        }

        public int IdTipo_Calculo { get; set; }
        public string? Nombre { get; set; }
        public bool? Anulado { get; set; }

        public virtual ICollection<NNomenclador_Base> NNomenclador_Bases { get; set; }
    }
}
