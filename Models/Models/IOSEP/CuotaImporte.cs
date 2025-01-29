using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CuotaImporte
    {
        public int IdCuota { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaCarga { get; set; }
    }
}
