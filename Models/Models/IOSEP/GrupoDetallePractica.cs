using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoDetallePractica
    {
        public int IdGrupoDetallePracticas { get; set; }
        public int IdGrupoPracticas { get; set; }
        public int IdPractica { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual GrupoPractica IdGrupoPracticasNavigation { get; set; } = null!;
        public virtual NPracticas_Base IdPracticaNavigation { get; set; } = null!;
    }
}
