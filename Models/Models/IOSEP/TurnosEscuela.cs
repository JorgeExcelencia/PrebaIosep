using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TurnosEscuela
    {
        public int TurnoEscuelaId { get; set; }
        public string Descripcion { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public int? MotivoAnulaId { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
