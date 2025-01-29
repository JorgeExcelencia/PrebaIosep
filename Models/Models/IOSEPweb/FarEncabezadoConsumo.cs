using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEncabezadoConsumo
    {
        public FarEncabezadoConsumo()
        {
            FarDetalleConsumos = new HashSet<FarDetalleConsumo>();
        }

        public int IdEncabezado { get; set; }
        public int IdFarmacia { get; set; }
        public int IdAfiliado { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public int IdPrescriptor { get; set; }
        public string? OpCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FarDetalleConsumo> FarDetalleConsumos { get; set; }
    }
}
