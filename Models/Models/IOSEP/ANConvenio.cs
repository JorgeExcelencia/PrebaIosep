using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANConvenio
    {
        public ANConvenio()
        {
            ANConvenioPracticas = new HashSet<ANConvenioPractica>();
            ANConvenioRestriccions = new HashSet<ANConvenioRestriccion>();
            ANConvenioValors = new HashSet<ANConvenioValor>();
        }

        public int ANConvenioID { get; set; }
        public int PrestadorID { get; set; }
        public int? ResolucionID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<ANConvenioPractica> ANConvenioPracticas { get; set; }
        public virtual ICollection<ANConvenioRestriccion> ANConvenioRestriccions { get; set; }
        public virtual ICollection<ANConvenioValor> ANConvenioValors { get; set; }
    }
}
