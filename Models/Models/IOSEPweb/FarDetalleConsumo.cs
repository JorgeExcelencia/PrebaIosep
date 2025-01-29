using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetalleConsumo
    {
        public int IdDetalle { get; set; }
        public int IdEncabezado { get; set; }
        public int NroRegistro { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CodigoBarras { get; set; }
        public string? CodigoTroquel { get; set; }
        public string? CodigoKairos { get; set; }
        public decimal Importe { get; set; }
        public decimal Cobertura { get; set; }
        public byte Cantidad { get; set; }
        public bool Anulado { get; set; }

        public virtual FarEncabezadoConsumo IdEncabezadoNavigation { get; set; } = null!;
    }
}
