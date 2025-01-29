using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosPorGrupoPracticasHistorial
    {
        public int IdCentroPorGrupoHistorial { get; set; }
        public int IdCentroPorGrupo { get; set; }
        public int IdCentroDeImagen { get; set; }
        public int IdGrupoPracticas { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public int SonIguales { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string? MotivoRedistribucion { get; set; }
    }
}
