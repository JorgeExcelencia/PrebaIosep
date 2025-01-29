using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarSucursale
    {
        public FarSucursale()
        {
            FarEncabezadoCompras = new HashSet<FarEncabezadoCompra>();
            FarEncabezadoVenta = new HashSet<FarEncabezadoVentum>();
            FarEntregaMedicacionPendientes = new HashSet<FarEntregaMedicacionPendiente>();
            FarRemitoTemporalEncabezadoSucursalDestinos = new HashSet<FarRemitoTemporalEncabezado>();
            FarRemitoTemporalEncabezadoSucursalOrigens = new HashSet<FarRemitoTemporalEncabezado>();
            FarVentaPendientes = new HashSet<FarVentaPendiente>();
        }

        public int SucursalId { get; set; }
        public string Nombre { get; set; } = null!;
        public string PuntoVenta { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<FarEncabezadoCompra> FarEncabezadoCompras { get; set; }
        public virtual ICollection<FarEncabezadoVentum> FarEncabezadoVenta { get; set; }
        public virtual ICollection<FarEntregaMedicacionPendiente> FarEntregaMedicacionPendientes { get; set; }
        public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezadoSucursalDestinos { get; set; }
        public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezadoSucursalOrigens { get; set; }
        public virtual ICollection<FarVentaPendiente> FarVentaPendientes { get; set; }
    }
}
