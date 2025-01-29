using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Empresa
    {
        public Empresa()
        {
            ListaIndicadores = new HashSet<ListaIndicadore>();
        }

        public int IdEmpresa { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ListaIndicadore> ListaIndicadores { get; set; }
    }
}
