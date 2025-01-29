using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarPresupuestoDetalle
    {
        public int PresupuestoDetalleId { get; set; }
        public int PresupuestoId { get; set; }
        public int NroRegistro { get; set; }
        public int NuevaDro { get; set; }
        public int MultiDro { get; set; }
        public string? Presentacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Reconoce { get; set; }
        public decimal Iosep { get; set; }
        public decimal Coseguro { get; set; }
        public string? Crea { get; set; }
        public DateTime? CreaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual FarPresupuesto Presupuesto { get; set; } = null!;
    }
}
