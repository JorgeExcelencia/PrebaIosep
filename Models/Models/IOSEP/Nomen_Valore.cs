using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomen_Valore
    {
        public int IdNomen_Valores { get; set; }
        public int IdNomenclador { get; set; }
        public short? IdTipoNom { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? Total { get; set; }
        public bool Anulado { get; set; }
    }
}
