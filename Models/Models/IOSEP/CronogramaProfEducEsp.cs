using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CronogramaProfEducEsp
    {
        public int CronogramaID { get; set; }
        public int ServicioPEEID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int DiaID { get; set; }
        public string? Frecuencia { get; set; }
        public string? M_Desde { get; set; }
        public string? M_Hasta { get; set; }
        public string? S_Desde { get; set; }
        public string? S_Hasta { get; set; }
        public string? T_Desde { get; set; }
        public string? T_Hasta { get; set; }
        public string OperCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
