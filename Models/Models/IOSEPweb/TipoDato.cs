using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoDato
    {
        public TipoDato()
        {
            IndicadoreIdTipoDatoDenominadorNavigations = new HashSet<Indicadore>();
            IndicadoreIdTipoDatoNumeradorNavigations = new HashSet<Indicadore>();
        }

        public int IdTipoDato { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Indicadore> IndicadoreIdTipoDatoDenominadorNavigations { get; set; }
        public virtual ICollection<Indicadore> IndicadoreIdTipoDatoNumeradorNavigations { get; set; }
    }
}
