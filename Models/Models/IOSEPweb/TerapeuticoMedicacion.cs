using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TerapeuticoMedicacion
    {
        public int TerapeuticoMedicacionId { get; set; }
        public int TeraputicoId { get; set; }
        public int NuevaDro { get; set; }
        public int? NroRegistro { get; set; }
        public int DosisDiariaMg { get; set; }
        public DateTime Vigencia { get; set; }
        public byte DiasalMes { get; set; }
        public string? Autorizado { get; set; }
        public DateTime? FechaExpendio { get; set; }
        public string? OpExpende { get; set; }
        public bool Anulado { get; set; }

        public virtual Terapeutico Teraputico { get; set; } = null!;
    }
}
