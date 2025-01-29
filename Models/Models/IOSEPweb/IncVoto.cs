using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncVoto
    {
        public int VotosId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public Guid? Usuario { get; set; }
        public byte? Voto { get; set; }
        public bool Visto { get; set; }
        public bool Anulado { get; set; }

        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
    }
}
