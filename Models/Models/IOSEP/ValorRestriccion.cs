using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ValorRestriccion
    {
        public int ValorRestriccionID { get; set; }
        public int TipoRestriccionID { get; set; }
        public string Valor { get; set; } = null!;
        public string Descripción { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoRestriccion TipoRestriccion { get; set; } = null!;
    }
}
