using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConvenioPracticaFacturacion
    {
        public int IdConvenioPractica { get; set; }
        public int IdConvenio { get; set; }
        public string Codigo { get; set; } = null!;
        public int IdPrestadorHonorarios { get; set; }
        public int IdPrestadorGastos { get; set; }
        public string? Anulado { get; set; }
    }
}
