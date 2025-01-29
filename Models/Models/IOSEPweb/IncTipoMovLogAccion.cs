using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncTipoMovLogAccion
    {
        public IncTipoMovLogAccion()
        {
            IncMovLogs = new HashSet<IncMovLog>();
        }

        public int TipoMovLogAccionId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Accion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncMovLog> IncMovLogs { get; set; }
    }
}
