using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DetalleNotaDeCredito
    {
        public int DetalleNotaDeCreditoID { get; set; }
        public int EncabezadoNotaDeCreditoID { get; set; }
        public string NumeroBono { get; set; } = null!;
        public int? AutorizacionesId { get; set; }
        public int TipoNotaCreditoID { get; set; }
        public decimal ImporteBono { get; set; }
        public decimal ImporteBonoInteres { get; set; }
        public string Cajero { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; } = null!;
        public string? TipoOrden { get; set; }
        public bool Anulado { get; set; }

        public virtual EncabezadoNotaDeCredito EncabezadoNotaDeCredito { get; set; } = null!;
        public virtual TipoNotaCredito TipoNotaCredito { get; set; } = null!;
    }
}
