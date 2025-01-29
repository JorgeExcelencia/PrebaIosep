using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConsumoEncabezado
    {
        public ConsumoEncabezado()
        {
            ConsumoDetalles = new HashSet<ConsumoDetalle>();
        }

        public int IdConsumoEncabezado { get; set; }
        public int IdInstitucion { get; set; }
        public string Tipo { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public string NombreAfiliado { get; set; } = null!;
        public string CUIL { get; set; } = null!;
        public string NumeroAfiliado { get; set; } = null!;
        public bool Internado { get; set; }
        public int IdInternado { get; set; }
        public string Numero { get; set; } = null!;
        public int? IdPlan { get; set; }
        public string PlanNombre { get; set; } = null!;
        public int IdPrescriptor { get; set; }
        public string Prescriptor { get; set; } = null!;
        public string NombrePrescriptor { get; set; } = null!;
        public int? IdEfector { get; set; }
        public string? Efector { get; set; }
        public string CIE10 { get; set; } = null!;
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaPrestacion { get; set; }
        public bool IosepSalud { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public string? Observaciones { get; set; }
        public bool Confirmado { get; set; }
        public bool Anulado { get; set; }
        public bool Facturado { get; set; }
        public string? EfectorCobise { get; set; }

        public virtual ICollection<ConsumoDetalle> ConsumoDetalles { get; set; }
    }
}
