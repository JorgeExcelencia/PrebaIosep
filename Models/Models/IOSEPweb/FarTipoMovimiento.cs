using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarTipoMovimiento
    {
        public FarTipoMovimiento()
        {
            FarEncabezadoCompras = new HashSet<FarEncabezadoCompra>();
            FarEncabezadoVenta = new HashSet<FarEncabezadoVentum>();
        }

        public int IdTipoMovimiento { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string VentaCompra { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<FarEncabezadoCompra> FarEncabezadoCompras { get; set; }
        public virtual ICollection<FarEncabezadoVentum> FarEncabezadoVenta { get; set; }
    }
}
