using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Contable_Gasto
    {
        public Contable_Gasto()
        {
            Gastos_Preventivos = new HashSet<Gastos_Preventivo>();
        }

        public int ContableGastosId { get; set; }
        public int PresupuestoContableId { get; set; }
        public int CuentaContableId { get; set; }
        public decimal? Afectacion_Preventiva { get; set; }
        public decimal? Afectacion_Definitiva { get; set; }
        public decimal Importe_Credito { get; set; }
        public DateTime? Fecha_Aprobacion { get; set; }
        public decimal? Importe_Comprometido { get; set; }
        public decimal? Mandado_APagar { get; set; }
        public decimal? Importe_Ampliacion { get; set; }
        public DateTime? Fecha_Ampliacion { get; set; }
        public int UltimoNumero { get; set; }
        public int UltimoNumeroComp { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Contable CuentaContable { get; set; } = null!;
        public virtual Presupuesto_Contable PresupuestoContable { get; set; } = null!;
        public virtual ICollection<Gastos_Preventivo> Gastos_Preventivos { get; set; }
    }
}
