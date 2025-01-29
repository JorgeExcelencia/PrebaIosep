using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HistoriaClinica
    {
        public int IdHistoria { get; set; }
        public int IdEsquema { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Fecha { get; set; }
        public string? Antecedentes { get; set; }
        public string? ExamenFisico { get; set; }
        public string? Estudios { get; set; }
        public string? Diagnostico { get; set; }
        public string? Motivo { get; set; }
        public string? Modificaria { get; set; }
        public bool Anulado { get; set; }
        public string CreaOperador { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string AnulaOperador { get; set; } = null!;
        public DateTime AnulaFecha { get; set; }
    }
}
