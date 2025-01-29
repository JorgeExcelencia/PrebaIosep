using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Articulo
    {
        public int NroRegistro { get; set; }
        public string? Troquel { get; set; }
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string? Codbarras { get; set; }
        public decimal? Precio { get; set; }
        public string? Heladera { get; set; }
        public int? Formas { get; set; }
        public decimal? Precio_Compra { get; set; }
        public DateTime? Fecha_UltCompra { get; set; }
        public decimal? Iva { get; set; }
        public string Articulo1 { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
