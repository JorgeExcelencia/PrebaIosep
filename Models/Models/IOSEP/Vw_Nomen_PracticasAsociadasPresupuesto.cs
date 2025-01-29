using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomen_PracticasAsociadasPresupuesto
    {
        public string codigo { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public int IdNomencladorPadre { get; set; }
        public int IdNomenclador { get; set; }
        public string? CodigoAsociado { get; set; }
        public string? NombreAsociado { get; set; }
    }
}
