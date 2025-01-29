using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_EstadisticasOrdene
    {
        public string? Afiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string? TipoOrden { get; set; }
        public string Plan { get; set; } = null!;
        public DateTime Fecha_Emision { get; set; }
    }
}
