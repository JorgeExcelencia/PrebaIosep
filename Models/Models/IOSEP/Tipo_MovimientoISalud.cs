using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_MovimientoISalud
    {
        public int idtipo_movimiento { get; set; }
        public string codigo { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public string debe_haber { get; set; } = null!;
        public bool? mostrar { get; set; }
    }
}
