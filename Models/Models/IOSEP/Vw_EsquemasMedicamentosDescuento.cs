using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_EsquemasMedicamentosDescuento
    {
        public int IdAfiliado { get; set; }
        public int IdEsquema { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public int IdManualDat { get; set; }
        public string Troquel { get; set; } = null!;
        public decimal Importe { get; set; }
        public decimal Coseguro { get; set; }
        public decimal Reconoce { get; set; }
        public string ReconoceTipo { get; set; } = null!;
        public int NroRegistro { get; set; }
    }
}
