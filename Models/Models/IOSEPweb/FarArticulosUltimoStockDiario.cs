using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarArticulosUltimoStockDiario
    {
        public int IdUltimoStock { get; set; }
        public int SucursalId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int NroRegistro { get; set; }
        public decimal Stock { get; set; }
        public bool Anulado { get; set; }
    }
}
