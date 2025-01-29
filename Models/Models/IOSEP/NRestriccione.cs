using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NRestriccione
    {
        public int IdRrestricciones { get; set; }
        public int? IdNNomenclador { get; set; }
        public byte? edad_minima { get; set; }
        public byte? edad_maxima { get; set; }
        public bool? informa { get; set; }
        public byte? idsexo { get; set; }
        public bool? auditoria { get; set; }
        public byte? mensual { get; set; }
        public byte? bimestral { get; set; }
        public byte? trimestral { get; set; }
        public byte? semestral { get; set; }
        public byte? anual { get; set; }
        public bool anulado { get; set; }
        public int? Carencias { get; set; }
        public int? DiasAutorizados { get; set; }
    }
}
