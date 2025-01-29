using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPrioridad
    {
        public IncPrioridad()
        {
            IncMovIncidenciasHeads = new HashSet<IncMovIncidenciasHead>();
        }

        public int PrioridadId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte[]? Avatar { get; set; }
        public string? Color { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncMovIncidenciasHead> IncMovIncidenciasHeads { get; set; }
    }
}
