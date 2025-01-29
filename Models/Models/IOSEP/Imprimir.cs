using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Imprimir
    {
        public long IdImprimir { get; set; }
        public DateTime Fecha { get; set; }
        public string JSON { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime? Impreso { get; set; }
        public string? Estado { get; set; }
    }
}
