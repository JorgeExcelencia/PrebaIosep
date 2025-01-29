using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosDeImagen
    {
        public CentrosDeImagen()
        {
            CentrosPorGrupoDomicilios = new HashSet<CentrosPorGrupoDomicilio>();
            CentrosPorGrupoPracticas = new HashSet<CentrosPorGrupoPractica>();
        }

        public int IdCentroDeImagen { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
        public int PrestadorID { get; set; }
        public bool? Otros { get; set; }
        public bool? Internados { get; set; }
        public bool? Ambulatorio { get; set; }

        public virtual ICollection<CentrosPorGrupoDomicilio> CentrosPorGrupoDomicilios { get; set; }
        public virtual ICollection<CentrosPorGrupoPractica> CentrosPorGrupoPracticas { get; set; }
    }
}
