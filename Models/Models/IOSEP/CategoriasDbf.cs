using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CategoriasDbf
    {
        public string? CODIGO { get; set; }
        public string? NOMBRE { get; set; }
        public decimal? APORTE { get; set; }
        public decimal? ADICIONAL { get; set; }
        public decimal? ESTLABOR { get; set; }
        public decimal? TITULAR { get; set; }
        public decimal? HFEM { get; set; }
        public decimal? HMAS { get; set; }
        public bool? VOLUNTAR { get; set; }
        public decimal? COD_ANSES { get; set; }
    }
}
