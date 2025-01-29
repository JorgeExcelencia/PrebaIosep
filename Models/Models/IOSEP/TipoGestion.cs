using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoGestion
    {
        public int IdTipoGestion { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdCategoria { get; set; }
        public bool IosepSalud { get; set; }
        public bool Anulado { get; set; }
    }
}
