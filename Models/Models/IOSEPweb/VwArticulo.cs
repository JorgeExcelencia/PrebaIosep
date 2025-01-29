using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwArticulo
    {
        public int NroRegistro { get; set; }
        public string? Troquel { get; set; }
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string? Codbarras { get; set; }
        public decimal? Precio { get; set; }
        public string? Heladera { get; set; }
        public string Articulo { get; set; } = null!;
        public bool? Baja { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal Unidades { get; set; }
    }
}
