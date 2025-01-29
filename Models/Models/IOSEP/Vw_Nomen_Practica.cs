using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomen_Practica
    {
        public string codigo { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public int IdTipoPractica { get; set; }
        public string NombreTipoPractica { get; set; } = null!;
        public string NombreModalidad { get; set; } = null!;
        public int IdModalidad { get; set; }
        public int idnomenclador { get; set; }
    }
}
