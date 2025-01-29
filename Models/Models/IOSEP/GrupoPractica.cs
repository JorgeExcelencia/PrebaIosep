using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoPractica
    {
        public GrupoPractica()
        {
            CentrosPorGrupoDomicilios = new HashSet<CentrosPorGrupoDomicilio>();
            CentrosPorGrupoPracticas = new HashSet<CentrosPorGrupoPractica>();
            GrupoDetallePracticas = new HashSet<GrupoDetallePractica>();
            GrupoPrestadores = new HashSet<GrupoPrestadore>();
        }

        public int IdGrupoPracticas { get; set; }
        public string NombreGrupo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool CargarDiagnostico { get; set; }
        public bool Anulado { get; set; }
        public bool Internado { get; set; }
        public int? SectorId { get; set; }
        public bool? ControlCupo { get; set; }

        public virtual ICollection<CentrosPorGrupoDomicilio> CentrosPorGrupoDomicilios { get; set; }
        public virtual ICollection<CentrosPorGrupoPractica> CentrosPorGrupoPracticas { get; set; }
        public virtual ICollection<GrupoDetallePractica> GrupoDetallePracticas { get; set; }
        public virtual ICollection<GrupoPrestadore> GrupoPrestadores { get; set; }
    }
}
