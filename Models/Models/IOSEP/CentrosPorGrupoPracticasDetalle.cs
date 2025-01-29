using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosPorGrupoPracticasDetalle
    {
        public int IdCentroPorGrupoDetalle { get; set; }
        public int IdCentroPorGrupo { get; set; }
        public int IdPractica { get; set; }
        public decimal Cupo { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
