using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomen_DatosNomenclador
    {
        public int idnomenclador { get; set; }
        public string codigo { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? Total { get; set; }
        public string tipo { get; set; } = null!;
    }
}
