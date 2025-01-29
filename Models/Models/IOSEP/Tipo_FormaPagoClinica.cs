using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_FormaPagoClinica
    {
        public int IdFormaPago { get; set; }
        public int Codigo { get; set; }
        public string Detalle { get; set; } = null!;
    }
}
