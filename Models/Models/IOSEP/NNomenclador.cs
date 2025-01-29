using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NNomenclador
    {
        public int IdNNomenclador { get; set; }
        public int? IdNomenclador_Base { get; set; }
        public int? IdPrestador { get; set; }
        public bool? Anulado { get; set; }
    }
}
