using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Gastos_Preventivo
    {
        public Gastos_Preventivo()
        {
            Gastos_Compromisos = new HashSet<Gastos_Compromiso>();
        }

        public int Gastos_PreventivosID { get; set; }
        public int ContableGastosID { get; set; }
        public string Expediente { get; set; } = null!;
        public string Ref_Expediente { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public int Asiento_Prev { get; set; }
        public int AsientoRef_Prev { get; set; }
        public decimal AfectacionPreventiva { get; set; }
        public decimal ImporteComprometido { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaAfectacion { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual Contable_Gasto ContableGastos { get; set; } = null!;
        public virtual ICollection<Gastos_Compromiso> Gastos_Compromisos { get; set; }
    }
}
