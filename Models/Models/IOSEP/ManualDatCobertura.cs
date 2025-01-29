using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ManualDatCobertura
    {
        public int IdManualDatCobertura { get; set; }
        public int? IdManual { get; set; }
        public DateTime? fec_act { get; set; }
        public string? troquel { get; set; }
        public string? nombre { get; set; }
        public string? present { get; set; }
        public string? ioma { get; set; }
        public string? laborat { get; set; }
        public decimal? Cobertura_ambulatorio { get; set; }
        public decimal? Cobertura_Internado { get; set; }
        public DateTime? Vigencia_Cobertura { get; set; }
        public DateTime? fecha { get; set; }
        public int? registro { get; set; }
        public string? barras { get; set; }
        public bool anulado { get; set; }
        public string? Producto { get; set; }
        public string? Obs { get; set; }
        public int? ManualDatCoberturaIDEnc { get; set; }
    }
}
