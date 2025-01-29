using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NExcluye_Facturacion
    {
        public int IdExcluye_Facturacion { get; set; }
        public int IdNNomenclador { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public bool Anulado { get; set; }
    }
}
