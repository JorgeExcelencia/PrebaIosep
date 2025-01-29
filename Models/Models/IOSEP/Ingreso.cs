using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ingreso
    {
        public int IdIngresos { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoIngresoId { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public string? Periodo { get; set; }
        public string? Observaciones { get; set; }
        public string? Beneficiario { get; set; }
        public decimal Importe { get; set; }
        public int? CuentaContableId { get; set; }

        public virtual Tipo_Ingreso TipoIngreso { get; set; } = null!;
    }
}
