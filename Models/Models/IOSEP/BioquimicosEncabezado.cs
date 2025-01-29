using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class BioquimicosEncabezado
    {
        public BioquimicosEncabezado()
        {
            BioquimicosDetalles = new HashSet<BioquimicosDetalle>();
        }

        public int IdBioquimicosEncabezado { get; set; }
        public int IdBioquimicosConsumo { get; set; }
        public int IdAfiliado { get; set; }
        public string NombreAfiliado { get; set; } = null!;
        public string CUIL { get; set; } = null!;
        public string NumeroAfiliado { get; set; } = null!;
        public int IdInternado { get; set; }
        public string Numero { get; set; } = null!;
        public int? IdPlan { get; set; }
        public string PlanNombre { get; set; } = null!;
        public int IdPrescriptor { get; set; }
        public string Prescriptor { get; set; } = null!;
        public string NombrePrescriptor { get; set; } = null!;
        public string CIE10 { get; set; } = null!;
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool IosepSalud { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public string? Observaciones { get; set; }
        public bool Confirmado { get; set; }
        public bool Anulado { get; set; }

        public virtual BioquimicosConsumo IdBioquimicosConsumoNavigation { get; set; } = null!;
        public virtual ICollection<BioquimicosDetalle> BioquimicosDetalles { get; set; }
    }
}
