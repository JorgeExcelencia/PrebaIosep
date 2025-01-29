using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomen_PracticasNoAsociada
    {
        public string nombre { get; set; } = null!;
        public string codigo { get; set; } = null!;
        public int IdNomenclador { get; set; }
        public int IdPracticasNoAsociadas { get; set; }
    }
}
