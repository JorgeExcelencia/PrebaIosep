using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ChequesEnBlanco
    {
        public ChequesEnBlanco()
        {
            Cheques = new HashSet<Cheque>();
        }

        public int ChequesBlancosID { get; set; }
        public string NumDesde { get; set; } = null!;
        public string NumHasta { get; set; } = null!;
        public int CantidadDisponible { get; set; }
        public int CuentaBancoID { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool? Automatico { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Banco CuentaBanco { get; set; } = null!;
        public virtual ICollection<Cheque> Cheques { get; set; }
    }
}
