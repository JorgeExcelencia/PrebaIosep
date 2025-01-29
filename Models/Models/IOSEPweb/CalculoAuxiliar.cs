using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class CalculoAuxiliar
    {
        public CalculoAuxiliar()
        {
            Indicadores = new HashSet<Indicadore>();
            ListaIndicadores = new HashSet<ListaIndicadore>();
        }

        public int IdCalculoAuxiliar { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Indicadore> Indicadores { get; set; }
        public virtual ICollection<ListaIndicadore> ListaIndicadores { get; set; }
    }
}
