using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DetallePreBono
    {
        public int DetallePreBonoID { get; set; }
        public int EncabezadoPreBonoId { get; set; }
        public int IdNomenclador { get; set; }
        public byte Cantidad_Solicitada { get; set; }
        public byte Cantidad_Autorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Coseguro_Honorarios { get; set; }
        public decimal Coseguro_Gastos { get; set; }
        public decimal Reconoce_Honorarios { get; set; }
        public decimal Reconoce_Gastos { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        public decimal? Factura_Honorarios { get; set; }
        public decimal? Factura_Gastos { get; set; }
        public DateTime? FechaPrestacion { get; set; }
        public int? IdEfector { get; set; }
        public bool Anulada { get; set; }
        public string? MotivoAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperAnula { get; set; }

        public virtual EncabezadoPreBono EncabezadoPreBono { get; set; } = null!;
        public virtual NPracticas_Base IdNomencladorNavigation { get; set; } = null!;
    }
}
