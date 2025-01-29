using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleVenta
    {
        public FarDetalleVenta()
        {
            FarDetalleEntregaMedicamentos = new HashSet<FarDetalleEntregaMedicamento>();
            FarIdentificacionCompras = new HashSet<FarIdentificacionCompra>();
        }

        public int IdDetalleVentas { get; set; }
        public int IdEncabezadoVenta { get; set; }
        public int NroRegistro { get; set; }
        public string Articulo { get; set; } = null!;
        public int? NuevaDro { get; set; }
        public int? MultiDro { get; set; }
        public string? Presentacion { get; set; }
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public bool Trazado { get; set; }
        public string? Lote { get; set; }
        public string? Vence { get; set; }
        public bool Deriva { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }
        public decimal? Stock { get; set; }
        public decimal CantidadEntregada { get; set; }
        public DateTime? FechaProxEntrega { get; set; }

        public virtual FarEncabezadoVentum IdEncabezadoVentaNavigation { get; set; } = null!;
        public virtual ICollection<FarDetalleEntregaMedicamento> FarDetalleEntregaMedicamentos { get; set; }
        public virtual ICollection<FarIdentificacionCompra> FarIdentificacionCompras { get; set; }
    }
}
