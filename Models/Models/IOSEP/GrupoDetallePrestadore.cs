using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoDetallePrestadore
    {
        public int IdGrupoDetallePrestador { get; set; }
        public int IdGrupoPrestador { get; set; }
        public int IdPrestador { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual GrupoPrestadore IdGrupoPrestadorNavigation { get; set; } = null!;
    }
}
