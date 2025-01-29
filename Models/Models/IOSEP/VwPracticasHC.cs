using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwPracticasHC
    {
        public int idautoriza { get; set; }
        public int? IdAfiliado { get; set; }
        public string numero { get; set; } = null!;
        public int iddelegacion { get; set; }
        public int? idprescriptor { get; set; }
        public int? idefector { get; set; }
        public int? iddiagnostico { get; set; }
        public int? idnomenclador { get; set; }
        public byte? cantidad { get; set; }
        public DateTime? fecha_prescripcion { get; set; }
        public DateTime? fecha_emision { get; set; }
        public DateTime? fecha_vence { get; set; }
        public string? operador { get; set; }
        public decimal? honorarios { get; set; }
        public decimal? gastos { get; set; }
        public decimal? coseguro_honorarios { get; set; }
        public decimal? coseguro_gastos { get; set; }
        public decimal? reconoce_honorarios { get; set; }
        public decimal? reconoce_gastos { get; set; }
        public string? observacion { get; set; }
        public string? motivo { get; set; }
        public byte tipoautorizacion { get; set; }
        public byte? tipoid { get; set; }
        public int? iddetipo { get; set; }
        public string? autorizacion { get; set; }
        public short seimprimio { get; set; }
        public bool anulada { get; set; }
    }
}
