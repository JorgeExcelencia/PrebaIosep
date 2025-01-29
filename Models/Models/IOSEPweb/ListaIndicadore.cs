using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ListaIndicadore
    {
        public int IdListaIndicador { get; set; }
        public int IdEmpresa { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public short Nivel { get; set; }
        public string Agrupa { get; set; } = null!;
        public int IdIndicador { get; set; }
        public int? IdCalculoAuxiliar { get; set; }
        public bool Anulado { get; set; }

        public virtual CalculoAuxiliar? IdCalculoAuxiliarNavigation { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Indicadore IdIndicadorNavigation { get; set; } = null!;
    }
}
