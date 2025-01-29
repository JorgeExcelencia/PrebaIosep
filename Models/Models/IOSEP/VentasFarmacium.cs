using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VentasFarmacium
    {
        public long IdVentasFarmacia { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; } = null!;
        public int NroRegistro { get; set; }
        public string CodBarras { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public string QR { get; set; } = null!;
        public string NroLote { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public string Operador { get; set; } = null!;
        public bool Emitido { get; set; }
        public bool Anulado { get; set; }
        /// <summary>
        /// Valor final que abona el afiliado esta incluido el descuento del Coseguro y Reconoce
        /// </summary>
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        /// <summary>
        /// valor del medicamento segun nomenclador
        /// </summary>
        public decimal Importe { get; set; }
        public decimal Coseguro { get; set; }
        public decimal Reconoce { get; set; }
        public int IdManual { get; set; }
    }
}
