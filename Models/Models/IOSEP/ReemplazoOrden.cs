using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReemplazoOrden
    {
        public int IdReemplazoOrden { get; set; }
        public string Numero { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public string NuevoNumero { get; set; } = null!;
        public bool IosepSalud { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
