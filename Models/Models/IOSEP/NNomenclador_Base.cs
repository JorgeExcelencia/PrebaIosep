using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NNomenclador_Base
    {
        public int IdNomenclador_Base { get; set; }
        public int? IdTipo_Nomenclador { get; set; }
        public int? IdPractica_Base { get; set; }
        public int? IdNivel_Nomenclador { get; set; }
        public int? IdTipo_Calculo { get; set; }
        public bool? Anulado { get; set; }

        public virtual NNivel_Nomenclador? IdNivel_NomencladorNavigation { get; set; }
        public virtual NPracticas_Base? IdPractica_BaseNavigation { get; set; }
        public virtual NTipo_Calculo? IdTipo_CalculoNavigation { get; set; }
        public virtual NTipo_Nomenclador? IdTipo_NomencladorNavigation { get; set; }
    }
}
