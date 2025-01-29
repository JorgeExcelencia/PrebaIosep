using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Detalle_AsientoModelo
    {
        public int DetalleModeloId { get; set; }
        public int EncabezadoModeloId { get; set; }
        public string Debe_Haber { get; set; } = null!;
        public int CuentaContableTradicionalId { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Contables_Tradicional CuentaContableTradicional { get; set; } = null!;
        public virtual Encabezado_AsientoModelo EncabezadoModelo { get; set; } = null!;
    }
}
