using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosPorGrupoDomicilio
    {
        public int IdCentroPorGrupoDomicilio { get; set; }
        public int IdCentroDeImagen { get; set; }
        public int IdGrupoPracticas { get; set; }
        public string? Domicilio { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual CentrosDeImagen IdCentroDeImagenNavigation { get; set; } = null!;
        public virtual GrupoPractica IdGrupoPracticasNavigation { get; set; } = null!;
    }
}
