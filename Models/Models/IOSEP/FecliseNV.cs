using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class FecliseNV
    {
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public decimal? gastos { get; set; }
        public decimal? honorarios { get; set; }
        public decimal? cos_amb { get; set; }
        public decimal? cos_int { get; set; }
        public int? id_practica { get; set; }
    }
}
