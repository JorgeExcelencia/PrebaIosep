using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MedicamentosCatastrofico
    {
        public int IdMedicamentosCatastroficos { get; set; }
        public string? Principio { get; set; }
        public int NroReg { get; set; }
        public string Troquel { get; set; } = null!;
        public string Barra { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Nomiose { get; set; }
        public string? Presenta { get; set; }
        public string Lab { get; set; } = null!;
        public decimal Precio { get; set; }
        public string Cober { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
