using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReajusteCredito
    {
        public int ReajusteCreditoID { get; set; }
        public int EncabezadoNotaDeCreditoID { get; set; }
        public int NumeroCredito { get; set; }
        public decimal MontoTotalCred { get; set; }
        public decimal MontoReajuste { get; set; }
        public decimal MontoNotaCredito { get; set; }
        public DateTime FechaReajuste { get; set; }
        public string Operador { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual EncabezadoNotaDeCredito EncabezadoNotaDeCredito { get; set; } = null!;
    }
}
