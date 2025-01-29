using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Quirofano
    {
        public int IdQuirofano { get; set; }
        public int IdInternado { get; set; }
        public int IdCirujano { get; set; }
        public int? IdAnestesista { get; set; }
        public int? IdHemoterapia { get; set; }
        public int? IdBiopsia { get; set; }
        public int? Ayudante1 { get; set; }
        public int? Ayudante2 { get; set; }
        public int? IdInstrumentador { get; set; }
        public int? IdNeonatologo { get; set; }
        public int? IdCir_Quirofano { get; set; }
        public int? IdLaboratorio { get; set; }
        public int? IdFdos_Laparoscopico { get; set; }
        public string? Observaciones { get; set; }
        public string? Varios { get; set; }
        public int? IdMonitoraje { get; set; }
        public int? Radiologo { get; set; }
        public bool Anulada { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
    }
}
