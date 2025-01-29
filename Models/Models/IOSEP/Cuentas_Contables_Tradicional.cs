using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cuentas_Contables_Tradicional
    {
        public Cuentas_Contables_Tradicional()
        {
            AsientosModelos = new HashSet<AsientosModelo>();
            Detalle_AsientoModelos = new HashSet<Detalle_AsientoModelo>();
        }

        public int CuentaContableTradicionalId { get; set; }
        public string Codigo { get; set; } = null!;
        public int TipoCuentaContableId { get; set; }
        public int SumarizaId { get; set; }
        public byte Nivel { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Observaciones { get; set; }
        public bool Anulada { get; set; }
        public bool Imputable { get; set; }
        public string Cod_Referencia { get; set; } = null!;

        public virtual Tipo_CuentaContable TipoCuentaContable { get; set; } = null!;
        public virtual ICollection<AsientosModelo> AsientosModelos { get; set; }
        public virtual ICollection<Detalle_AsientoModelo> Detalle_AsientoModelos { get; set; }
    }
}
