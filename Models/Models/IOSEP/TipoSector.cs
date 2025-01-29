using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoSector
    {
        public byte IdSector { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdNomenclador { get; set; }
        public bool Anulada { get; set; }
    }
}
