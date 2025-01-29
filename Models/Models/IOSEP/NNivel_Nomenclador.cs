using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NNivel_Nomenclador
    {
        public NNivel_Nomenclador()
        {
            NNomenclador_Bases = new HashSet<NNomenclador_Base>();
        }

        public int IdNivel_Nomenclador { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NNomenclador_Base> NNomenclador_Bases { get; set; }
    }
}
