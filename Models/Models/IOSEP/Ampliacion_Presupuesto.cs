using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ampliacion_Presupuesto
    {
        public int AmpliacionPresupuestoId { get; set; }
        public int PresupuestoContableId { get; set; }
        public DateTime Fecha { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public string Gasto_Recurso { get; set; } = null!;
        public int CuentaContableId { get; set; }
        public decimal Importe { get; set; }
        public string Periodo_Aplicacion { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual Presupuesto_Contable PresupuestoContable { get; set; } = null!;
    }
}
