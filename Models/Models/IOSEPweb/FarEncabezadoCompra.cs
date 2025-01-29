using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEncabezadoCompra
    {
        public FarEncabezadoCompra()
        {
            FarDetalleCompras = new HashSet<FarDetalleCompra>();
        }

        public int IdEncabezadoCompras { get; set; }
        public int IdProveedor { get; set; }
        public int IdTipoComprobante { get; set; }
        public int SucursalId { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public decimal? ImporteComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public string? CaiComprobante { get; set; }
        public string Gnl { get; set; } = null!;
        public DateTime FechaRecepcion { get; set; }
        public string HoraRecepcion { get; set; } = null!;
        public string? OpCrea { get; set; }
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }
        public string? MotivoAnulacion { get; set; }
        public string? MotivoRestauracion { get; set; }
        public string? MotivoAjuste { get; set; }

        public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
        public virtual FarTipoMovimiento IdTipoComprobanteNavigation { get; set; } = null!;
        public virtual FarSucursale Sucursal { get; set; } = null!;
        public virtual ICollection<FarDetalleCompra> FarDetalleCompras { get; set; }
    }
}
