using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncTipoMovLog
    {
        public IncTipoMovLog()
        {
            IncMovLogs = new HashSet<IncMovLog>();
        }

        public int TipoMovLogId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<IncMovLog> IncMovLogs { get; set; }
    }
}
