using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NAsociadas_Facturacion
    {
        public int IdAsociadas_Facturacion { get; set; }
        public int? IdNNomenclador { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Importe { get; set; }
        public bool? Anulado { get; set; }
    }
}
