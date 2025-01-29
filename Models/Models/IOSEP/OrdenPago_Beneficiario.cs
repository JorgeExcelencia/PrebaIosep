using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenPago_Beneficiario
    {
        public int OrdenPago_BeneficiarioID { get; set; }
        public int OrdenPagoID { get; set; }
        public string CuilBeneficiario { get; set; } = null!;
        public string Beneficiario { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal Importe { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Pagado { get; set; }
        public bool Anulado { get; set; }

        public virtual Orden_Pago OrdenPago { get; set; } = null!;
    }
}
