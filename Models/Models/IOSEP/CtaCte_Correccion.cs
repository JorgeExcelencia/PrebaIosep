using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CtaCte_Correccion
    {
        public int idCorreccionCta { get; set; }
        public int IdAfiliado { get; set; }
        public int idCtaIosep { get; set; }
        public decimal ImporteFact { get; set; }
        public decimal ImporteReal { get; set; }
        public string Comprobante { get; set; } = null!;
    }
}
