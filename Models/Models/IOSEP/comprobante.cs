using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class comprobante
    {
        public comprobante()
        {
            comprobanteDetalles = new HashSet<comprobanteDetalle>();
            comprobanteLogs = new HashSet<comprobanteLog>();
        }

        public int IdComprobante { get; set; }
        public int IdAfiliado { get; set; }
        public int IdCajaTipoOrigen { get; set; }
        public string Numero { get; set; } = null!;
        public byte Cuotas { get; set; }
        public decimal? Importe { get; set; }
        public string? CodigoBarra { get; set; }
        public int? IdTipoMovimiento { get; set; }
        public int? IdDetalle { get; set; }
        public string? Detalle { get; set; }
        public int? IdEmpresa { get; set; }
        public string? Periodo { get; set; }
        public int? IdCtaCte { get; set; }
        public string? Estado { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<comprobanteDetalle> comprobanteDetalles { get; set; }
        public virtual ICollection<comprobanteLog> comprobanteLogs { get; set; }
    }
}
