using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HistorialMontoCredito
    {
        public int HistorialMontoCredito1 { get; set; }
        public int NumeroCredito { get; set; }
        public int NumNotaCredito { get; set; }
        public decimal MontoOriginal { get; set; }
        public decimal MontoNuevo { get; set; }
        public int CantCuotas { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
    }
}
