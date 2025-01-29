using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cheque
    {
        public int IdCheque { get; set; }
        public int ChequesBlancosID { get; set; }
        public string? Numero { get; set; }
        public string? Serie { get; set; }
        public string CuilPersona { get; set; } = null!;
        public int? PersonaID { get; set; }
        public string NombreImpreso { get; set; } = null!;
        public decimal Importe { get; set; }
        public string OperadorCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperadorImprime { get; set; }
        public DateTime? FechaImprime { get; set; }
        public string? OperadorAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Bloqueado { get; set; }
        public int? IdReintegro { get; set; }
        public int? IdOrdenPago { get; set; }
        public int? IdOrdenPagoAnticipo { get; set; }
        public int? IdOrdenPagoBeneficiario { get; set; }
        public bool Anulado { get; set; }

        public virtual ChequesEnBlanco ChequesBlancos { get; set; } = null!;
    }
}
