using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AcliseRX
    {
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? VIGENCIA { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
    }
}
