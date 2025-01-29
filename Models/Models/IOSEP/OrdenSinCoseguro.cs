using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenSinCoseguro
    {
        public int IdOrdenSinCoseguro { get; set; }
        public int IdDelegacion { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public string Numero { get; set; } = null!;
        public string TipoOrden { get; set; } = null!;
        public decimal Importe { get; set; }
        public decimal Coseguro { get; set; }
        public int IdPrestador { get; set; }
        public int? IdDiagnostico { get; set; }
        public string UserCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Facturado { get; set; }
        public DateTime? FechaFacturado { get; set; }
        public int? IdEncabezadoPresentacion { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionAnula { get; set; }
        public int? IdInstitucion { get; set; }
        public string? ComprobanteIncluye { get; set; }
        public string? ComprobantePaga { get; set; }
        public int? IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public DateTime? FechaDebito { get; set; }
        public string? OpDebito { get; set; }
        public bool? Definitivo { get; set; }
        public string? HCDetalle { get; set; }
    }
}
