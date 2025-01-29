using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cuentas_Banco
    {
        public Cuentas_Banco()
        {
            ChequesEnBlancos = new HashSet<ChequesEnBlanco>();
            ConciliacionBancaria = new HashSet<ConciliacionBancarium>();
            Movimiento_Cuenta = new HashSet<Movimiento_Cuentum>();
            OrdenPago_CuentaContables = new HashSet<OrdenPago_CuentaContable>();
        }

        public int CuentaBancoID { get; set; }
        public int BancoID { get; set; }
        public string Sucursal { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Rol { get; set; }
        public bool Anulado { get; set; }

        public virtual Banco Banco { get; set; } = null!;
        public virtual ICollection<ChequesEnBlanco> ChequesEnBlancos { get; set; }
        public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; }
        public virtual ICollection<Movimiento_Cuentum> Movimiento_Cuenta { get; set; }
        public virtual ICollection<OrdenPago_CuentaContable> OrdenPago_CuentaContables { get; set; }
    }
}
