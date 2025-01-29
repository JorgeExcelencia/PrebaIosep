using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AnaemnesisReducidum
    {
        public int AnaemnesisReducidaId { get; set; }
        public int PacienteId { get; set; }
        public int TurnoId { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Temperatura { get; set; }
        public int? Pulso { get; set; }
        public int? TensionArterialMaxima { get; set; }
        public int? TensionArterialMinima { get; set; }
        public int? Talla { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? EdadGestacional { get; set; }
        public decimal? PerimetroCefalico { get; set; }
        public decimal? MasaCorporal { get; set; }
        public decimal? Percentil { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string Usuario { get; set; } = null!;
    }
}
