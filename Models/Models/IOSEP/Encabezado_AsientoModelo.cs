using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_AsientoModelo
    {
        public Encabezado_AsientoModelo()
        {
            Detalle_AsientoModelos = new HashSet<Detalle_AsientoModelo>();
        }

        public int EncabezadoModeloId { get; set; }
        public int CuentaContableId { get; set; }
        public string Detalle { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual Cuentas_Contable CuentaContable { get; set; } = null!;
        public virtual ICollection<Detalle_AsientoModelo> Detalle_AsientoModelos { get; set; }
    }
}
