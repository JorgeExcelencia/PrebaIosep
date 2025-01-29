using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleEntregaMedicamento
    {
        public int IdDetalleEntregaMedicamentos { get; set; }
        public int IdEncabezadoEntregaMedicamentos { get; set; }
        public int IdDetalleVentas { get; set; }
        public int NroRegistro { get; set; }
        public string? Articulo { get; set; }
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public decimal CantidadSolicitada { get; set; }
        public decimal CantidadEntregar { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public string? Lote { get; set; }
        public string? Vence { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }

        public virtual FarDetalleVenta IdDetalleVentasNavigation { get; set; } = null!;
        public virtual FarEncabezadoEntregaMedicamento IdEncabezadoEntregaMedicamentosNavigation { get; set; } = null!;
    }
}
