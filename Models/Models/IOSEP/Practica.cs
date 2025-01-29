using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Practica
    {
        public int idpractica { get; set; }
        public int idautoriza { get; set; }
        public short IdTipo { get; set; }
        public short IdPlan { get; set; }
        public string codigo { get; set; } = null!;
        public short cantidad { get; set; }
        public decimal honorarios { get; set; }
        public decimal gastos { get; set; }
        public decimal coseguro_honorario { get; set; }
        public decimal coseguro_gastos { get; set; }
        public decimal reconoce_honorarios { get; set; }
        public decimal reconoce_gastos { get; set; }
    }
}
