using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomen_PracticasNoAsociadasPresupuesto
    {
        public string codigo { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public int IdNomencladorPadre { get; set; }
        public int IdNomenclador { get; set; }
        public string? CodigoNoAsociado { get; set; }
        public string? NombreNoAsociado { get; set; }
    }
}
