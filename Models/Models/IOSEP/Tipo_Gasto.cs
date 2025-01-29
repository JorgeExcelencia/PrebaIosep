using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Gasto
    {
        public int TipoGastoId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? TipoServicioId { get; set; }
        public string? Descripcion { get; set; }
        public int CuentaContableId { get; set; }
        public bool Anulado { get; set; }

        public virtual Tipo_Servicio? TipoServicio { get; set; }
    }
}
