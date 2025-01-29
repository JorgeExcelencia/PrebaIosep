using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VademecumFeclise
    {
        public VademecumFeclise()
        {
            VademecumDetalles = new HashSet<VademecumDetalle>();
        }

        public int IdVademecum { get; set; }
        public string Nombre { get; set; } = null!;
        public string Droga { get; set; } = null!;
        public string Cantidad { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public bool Unico { get; set; }
        public decimal UnitarioPromedio { get; set; }
        public decimal ConDescuento { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<VademecumDetalle> VademecumDetalles { get; set; }
    }
}
