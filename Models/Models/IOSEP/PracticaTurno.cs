using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PracticaTurno
    {
        public int PracticaTurnoID { get; set; }
        public int IdPractica_Base { get; set; }
        public int TurnoID { get; set; }
        public bool Anulado { get; set; }

        public virtual NPracticas_Base IdPractica_BaseNavigation { get; set; } = null!;
    }
}
