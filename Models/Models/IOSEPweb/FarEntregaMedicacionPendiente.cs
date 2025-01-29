using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEntregaMedicacionPendiente
    {
        public FarEntregaMedicacionPendiente()
        {
            FarDetalleEntregaMedicacionPendientes = new HashSet<FarDetalleEntregaMedicacionPendiente>();
        }

        public int FarEntregaMedicacionPendienteId { get; set; }
        public int? FarEncabezadoVentaId { get; set; }
        public int FarVentaPendienteId { get; set; }
        public int AfiliadoId { get; set; }
        public int TipoEntregaMedicacionId { get; set; }
        public int SucursalId { get; set; }
        public string NumeroComprobanteVenta { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public decimal ImporteTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual FarVentaPendiente FarVentaPendiente { get; set; } = null!;
        public virtual FarSucursale Sucursal { get; set; } = null!;
        public virtual TipoEntregaMedicacion TipoEntregaMedicacion { get; set; } = null!;
        public virtual ICollection<FarDetalleEntregaMedicacionPendiente> FarDetalleEntregaMedicacionPendientes { get; set; }
    }
}
