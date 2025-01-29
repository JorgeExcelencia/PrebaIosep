using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Indicadore
    {
        public Indicadore()
        {
            ListaIndicadores = new HashSet<ListaIndicadore>();
        }

        public int IdIndicador { get; set; }
        public string Detalle { get; set; } = null!;
        public int IdTipoIndicador { get; set; }
        public int IdTipoDatoNumerador { get; set; }
        public string FormulaNumerador { get; set; } = null!;
        public int IdTipoDatoDenominador { get; set; }
        public string FormulaDenominador { get; set; } = null!;
        public decimal MultiplicadorCociente { get; set; }
        public int IdCalculoAuxiliar { get; set; }
        public string? BaseDeDatos { get; set; }
        public string? IpBaseDeDatos { get; set; }
        public string? UsuarioBaseDeDatos { get; set; }
        public string? PasswordBaseDeDatos { get; set; }
        public bool Anulado { get; set; }

        public virtual CalculoAuxiliar IdCalculoAuxiliarNavigation { get; set; } = null!;
        public virtual TipoDato IdTipoDatoDenominadorNavigation { get; set; } = null!;
        public virtual TipoDato IdTipoDatoNumeradorNavigation { get; set; } = null!;
        public virtual TipoIndicador IdTipoIndicadorNavigation { get; set; } = null!;
        public virtual ICollection<ListaIndicadore> ListaIndicadores { get; set; }
    }
}
