using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarVentaPendiente
    {
        public FarVentaPendiente()
        {
            FarDetalleVentaPendientes = new HashSet<FarDetalleVentaPendiente>();
            FarEntregaMedicacionPendientes = new HashSet<FarEntregaMedicacionPendiente>();
        }

        public int FarVentaPendienteId { get; set; }
        public int AfiliadoId { get; set; }
        public int SucursalId { get; set; }
        public int TipoEntregaMedicacionId { get; set; }
        public int? PlanId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual FarSucursale Sucursal { get; set; } = null!;
        public virtual TipoEntregaMedicacion TipoEntregaMedicacion { get; set; } = null!;
        public virtual ICollection<FarDetalleVentaPendiente> FarDetalleVentaPendientes { get; set; }
        public virtual ICollection<FarEntregaMedicacionPendiente> FarEntregaMedicacionPendientes { get; set; }
    }
}
