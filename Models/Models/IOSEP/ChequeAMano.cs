using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ChequeAMano
    {
        public int ChequeAManoID { get; set; }
        public string NumeroCheque { get; set; } = null!;
        public int CuentaBancoID { get; set; }
        public decimal ImporteCheque { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
    }
}
