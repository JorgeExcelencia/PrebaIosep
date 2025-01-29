using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarVentasPago
    {
        public int IdExtraPagos { get; set; }
        public int IdEncabezadoVenta { get; set; }
        public short IdFormaPago { get; set; }
        public short Cuotas { get; set; }
        public decimal TotalCredito { get; set; }
        public decimal TotalCreditoSinInteres { get; set; }
        public decimal ValorCuota { get; set; }
        public bool Credito { get; set; }
        public bool Anulado { get; set; }

        public virtual FarEncabezadoVentum IdEncabezadoVentaNavigation { get; set; } = null!;
    }
}
