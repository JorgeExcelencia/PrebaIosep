using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Numeros_Movimiento
    {
        public int NumerosMovimientosId { get; set; }
        public int TipoMovimientoId { get; set; }
        public string Anio { get; set; } = null!;
        public string Numero { get; set; } = null!;
    }
}
