using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoPrestadore
    {
        public GrupoPrestadore()
        {
            GrupoDetallePrestadores = new HashSet<GrupoDetallePrestadore>();
        }

        public int IdGrupoPrestador { get; set; }
        public int IdGrupoPracticas { get; set; }
        public int IdCentro { get; set; }
        public string Centro { get; set; } = null!;
        public int Maximo { get; set; }
        public int Semana1 { get; set; }
        public int Semana2 { get; set; }
        public int Semana3 { get; set; }
        public int Semana4 { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual GrupoPractica IdGrupoPracticasNavigation { get; set; } = null!;
        public virtual ICollection<GrupoDetallePrestadore> GrupoDetallePrestadores { get; set; }
    }
}
