using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoRestriccion
    {
        public TipoRestriccion()
        {
            ValorRestriccions = new HashSet<ValorRestriccion>();
        }

        public int TipoRestriccionID { get; set; }
        public string Nombre { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<ValorRestriccion> ValorRestriccions { get; set; }
    }
}
