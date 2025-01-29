using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Nomenclador_feclisCC
    {
        public int IdNomenclador { get; set; }
        public string? Codigo_Convenio { get; set; }
        public string? Tipo_nomenclador { get; set; }
        public string? p_codigo { get; set; }
        public string? nombre { get; set; }
        public decimal? honorario { get; set; }
        public decimal? ayuda_1 { get; set; }
        public decimal? ayuda_2 { get; set; }
        public decimal? ayuda_3 { get; set; }
        public decimal? ayuda_4 { get; set; }
        public decimal? anestesia { get; set; }
        public decimal? instrumen { get; set; }
        public decimal? gastos { get; set; }
        public decimal? cos_amb { get; set; }
        public decimal? cos_int { get; set; }
        public DateTime? v_fecha { get; set; }
        public decimal? fijo { get; set; }
        public byte? ver { get; set; }
    }
}
