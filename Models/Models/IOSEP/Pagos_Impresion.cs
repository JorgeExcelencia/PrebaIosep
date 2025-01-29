using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pagos_Impresion
    {
        public int PagoID { get; set; }
        public string Comprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
