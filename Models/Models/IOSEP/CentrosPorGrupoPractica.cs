using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosPorGrupoPractica
    {
        public CentrosPorGrupoPractica()
        {
            AfiliadosCentroDeImagens = new HashSet<AfiliadosCentroDeImagen>();
        }

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

        public virtual CentrosDeImagen IdCentroDeImagenNavigation { get; set; } = null!;
        public virtual GrupoPractica IdGrupoPracticasNavigation { get; set; } = null!;
        public virtual ICollection<AfiliadosCentroDeImagen> AfiliadosCentroDeImagens { get; set; }
    }
}
