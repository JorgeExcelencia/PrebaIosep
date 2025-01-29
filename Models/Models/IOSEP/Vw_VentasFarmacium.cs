using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_VentasFarmacium
    {
        public long IdVentasFarmacia { get; set; }
        public string Cuil { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; } = null!;
        public string CodBarras { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public string QR { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? Nombre { get; set; }
        public string? Presentacion { get; set; }
        public string? Monodroga { get; set; }
        public int IdAfiliado { get; set; }
        public string NombreAfiliado { get; set; } = null!;
        public int? NroRegistro { get; set; }
        public int Cantidad { get; set; }
        public bool Emitido { get; set; }
        public decimal Importe { get; set; }
        public decimal Coseguro { get; set; }
        public decimal Reconoce { get; set; }
        public decimal Precio { get; set; }
        public decimal? ImporteActual { get; set; }
    }
}
