using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OtrosPrecio
    {
        public string? codigo { get; set; }
        public string? p_codigo { get; set; }
        public DateTime? v_fecha { get; set; }
        public decimal? honora { get; set; }
        public decimal? ayuda_1 { get; set; }
        public decimal? ayuda_2 { get; set; }
        public decimal? ayuda_3 { get; set; }
        public decimal? ayuda_4 { get; set; }
        public decimal? anestesia { get; set; }
        public decimal? instrumen { get; set; }
        public decimal? gastos { get; set; }
        public decimal? cos_amb { get; set; }
        public decimal? cos_int { get; set; }
        public decimal? fijo { get; set; }
        public byte? ver { get; set; }
        public bool? anulado { get; set; }
        public int? IdInstitucion { get; set; }
    }
}
