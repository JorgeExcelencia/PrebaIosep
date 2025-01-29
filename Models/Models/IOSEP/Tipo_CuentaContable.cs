using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_CuentaContable
    {
        public Tipo_CuentaContable()
        {
            Cuentas_Contables = new HashSet<Cuentas_Contable>();
            Cuentas_Contables_Tradicionals = new HashSet<Cuentas_Contables_Tradicional>();
        }

        public int TipoCuentaContableId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Cuentas_Contable> Cuentas_Contables { get; set; }
        public virtual ICollection<Cuentas_Contables_Tradicional> Cuentas_Contables_Tradicionals { get; set; }
    }
}
