using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_GetEsquema
    {
        public int IdEsquema { get; set; }
        public int IdAfiliado { get; set; }
        public string Observaciones { get; set; } = null!;
        public string Resolucion { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
    }
}
