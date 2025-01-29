using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HCDigitalizadum
    {
        public int HCDigitalizadaID { get; set; }
        public string NumeroHC { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public DateTime fechaPrimerConsulta { get; set; }
        public int MedicoCabeceraID { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime? FechaUltMod { get; set; }
        public string? UsuarioUltMod { get; set; }
        public bool Anulado { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual Prestadore MedicoCabecera { get; set; } = null!;
    }
}
