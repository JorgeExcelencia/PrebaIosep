using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class aclisePreciosEnero
    {
        public string? codigo { get; set; }
        public DateTime? vigencia { get; set; }
        public decimal? honorarios { get; set; }
        public decimal? gastos { get; set; }
    }
}
