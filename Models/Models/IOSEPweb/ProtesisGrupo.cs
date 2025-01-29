using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ProtesisGrupo
    {
        public ProtesisGrupo()
        {
            ProtesisPracticas = new HashSet<ProtesisPractica>();
        }

        public int GrupoId { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ProtesisPractica> ProtesisPracticas { get; set; }
    }
}
