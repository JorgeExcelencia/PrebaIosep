using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_RelacionSectorPension
    {
        public byte IdSector { get; set; }
        public string NombreSector { get; set; } = null!;
        public int IdNomenclador { get; set; }
        public string codigo { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
    }
}
