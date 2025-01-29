using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwEsquemaPracticas_output
    {
        public int IdEsquema { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public int IdAfiliado { get; set; }
        public int IdNomenclador { get; set; }
        public string Practica { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public decimal Importe { get; set; }
        public decimal Reconoce { get; set; }
        public string ReconoceTipo { get; set; } = null!;
        public decimal Coseguro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
