using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AsientosPartida
    {
        public int AsientosPartidasID { get; set; }
        public int ContableGastosID { get; set; }
        public int NroAsiento { get; set; }
        public int NroAsientoRef { get; set; }
        public string Expediente { get; set; } = null!;
        public string Ref_Expediente { get; set; } = null!;
        public int? Gastos_PreventivosID { get; set; }
        public int? Gastos_CompromisosID { get; set; }
        public int? OrdenPago_CuentaContableID { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
    }
}
