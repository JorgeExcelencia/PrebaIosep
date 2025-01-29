using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ClinicaCoseguro
    {
        public int IdClinicaCoseguro { get; set; }
        public int IdClinica { get; set; }
        public decimal? LimitexAfiliado { get; set; }
        public decimal? LimitexClinica { get; set; }
    }
}
