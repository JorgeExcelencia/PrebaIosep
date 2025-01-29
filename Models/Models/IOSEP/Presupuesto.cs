using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Comprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public byte Cantidad_Cuotas { get; set; }
        public int IdCajaTipoOrigen { get; set; }
        public int IdInternado { get; set; }
        public string Operador { get; set; } = null!;
        public int IdPago { get; set; }
        public int IdTipoFormaPago { get; set; }
        public bool Anulado { get; set; }
    }
}
