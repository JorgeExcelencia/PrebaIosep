using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_ComprasFarmacium
    {
        public long IdComprasFarmacia { get; set; }
        public long IdCotizaciones_Envio { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; } = null!;
        public int NroRegistro { get; set; }
        public string CodBarras { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public string QR { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public bool Emitido { get; set; }
        public bool Anulado { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int IdManual { get; set; }
        public string NroLote { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public int IdComprasTipo { get; set; }
        public string Resolucion { get; set; } = null!;
        public int IdCotizaciones_Pedido { get; set; }
        public string? Nombre { get; set; }
        public string? Presentacion { get; set; }
        public string? Monodroga { get; set; }
        public string? NombreProveedor { get; set; }
        public string Observaciones { get; set; } = null!;
    }
}
