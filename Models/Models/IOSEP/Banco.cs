using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Banco
    {
        public Banco()
        {
            Cuentas_Bancos = new HashSet<Cuentas_Banco>();
        }

        public int BancoID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Cuentas_Banco> Cuentas_Bancos { get; set; }
    }
}
