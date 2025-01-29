using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PracticasDelegacion
    {
        public int IdPracticaDelegacion { get; set; }
        public int IdPractica_Base { get; set; }
        public short IdDelegacion { get; set; }
        public string UserCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual Delegacione IdDelegacionNavigation { get; set; } = null!;
        public virtual NPracticas_Base IdPracticaDelegacionNavigation { get; set; } = null!;
    }
}
