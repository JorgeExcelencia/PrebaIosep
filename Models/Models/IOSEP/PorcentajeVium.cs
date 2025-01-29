using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PorcentajeVium
    {
        public int PorcentajeViaID { get; set; }
        public int Porcentaje { get; set; }
        public int TipoViaID { get; set; }
        public int NumeroCirugiaID { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual NumeroCirugium NumeroCirugia { get; set; } = null!;
        public virtual TipoVium TipoVia { get; set; } = null!;
    }
}
