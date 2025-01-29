using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoEstadoRemito
    {
        public TipoEstadoRemito()
        {
            FarRemitoTemporalEncabezados = new HashSet<FarRemitoTemporalEncabezado>();
        }

        public int EstadoId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezados { get; set; }
    }
}
