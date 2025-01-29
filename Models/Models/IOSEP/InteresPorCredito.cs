using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InteresPorCredito
    {
        public int InteresPorCreditoID { get; set; }
        public decimal Valor { get; set; }
        public DateTime Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
