using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NPracticasAsociada
    {
        public int IdPracticaAsociada { get; set; }
        public int IdPractica_Base { get; set; }
        public int IdPractica_BaseAsocia { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public bool Anulado { get; set; }
    }
}
