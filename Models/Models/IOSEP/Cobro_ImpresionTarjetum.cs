using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cobro_ImpresionTarjetum
    {
        public int Cobro_ImpresionTarjetaID { get; set; }
        public int? IdAfiliado { get; set; }
        public string AfiliadoCuil { get; set; } = null!;
        public int MotivoReimpresionID { get; set; }
        public decimal? MontoReimpresion { get; set; }
        public string? Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string OpeCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpeModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public int? Impresa { get; set; }
        public string? NumComprobante { get; set; }
        public bool Anulado { get; set; }
        public string? MotivoAnula { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
