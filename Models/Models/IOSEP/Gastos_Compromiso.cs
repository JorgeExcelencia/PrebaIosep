using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Gastos_Compromiso
    {
        public int Gastos_CompromisosID { get; set; }
        public int ContableGastosID { get; set; }
        public int Gastos_PreventivosID { get; set; }
        public string Expediente { get; set; } = null!;
        public string Ref_Expediente { get; set; } = null!;
        public string CuilBeneficiario { get; set; } = null!;
        public string Beneficiario { get; set; } = null!;
        public int Asiento_Comp { get; set; }
        public int AsientoRef_Comp { get; set; }
        public decimal Importe_Comprometido { get; set; }
        public DateTime FechaCompromiso { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual Gastos_Preventivo Gastos_Preventivos { get; set; } = null!;
    }
}
