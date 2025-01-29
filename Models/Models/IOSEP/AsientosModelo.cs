using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AsientosModelo
    {
        public int AsientoModeloId { get; set; }
        public int CuentaPresupuestariaId { get; set; }
        public int CuentaTradicionalId { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Contable CuentaPresupuestaria { get; set; } = null!;
        public virtual Cuentas_Contables_Tradicional CuentaTradicional { get; set; } = null!;
    }
}
