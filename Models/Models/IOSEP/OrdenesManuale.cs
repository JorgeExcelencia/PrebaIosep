using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenesManuale
    {
        public int IdOrdenManual { get; set; }
        public string? COD_AUT { get; set; }
        public string? SUCURSAL { get; set; }
        public string? NUMERO { get; set; }
        public DateTime? FECHA { get; set; }
        public string? OPERADOR { get; set; }
        public string? HORA { get; set; }
        public string? TRANSAC { get; set; }
        public bool? ESTADO { get; set; }
        public string? T_EMITE { get; set; }
        public int? DIGI { get; set; }
    }
}
