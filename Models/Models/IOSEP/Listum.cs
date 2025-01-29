using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Listum
    {
        public int IdLista { get; set; }
        public string CODIGO { get; set; } = null!;
        public string P_CODIGO { get; set; } = null!;
        public DateTime V_FECHA { get; set; }
        public decimal Honorario { get; set; }
        public decimal Ayuda_1 { get; set; }
        public decimal Ayuda_2 { get; set; }
        public decimal Ayuda_3 { get; set; }
        public decimal Ayuda_4 { get; set; }
        public decimal Anestesia { get; set; }
        public decimal Instrumen { get; set; }
        public decimal Gastos { get; set; }
        public decimal Cos_amb { get; set; }
        public decimal Cos_int { get; set; }
        public decimal Fijo { get; set; }
        public decimal? Ver { get; set; }
    }
}
