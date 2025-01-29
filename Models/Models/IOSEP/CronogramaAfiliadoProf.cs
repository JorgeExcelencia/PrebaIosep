using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CronogramaAfiliadoProf
    {
        public int CronogramaAfiliadoProfID { get; set; }
        public int IdAfiliado { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int ServicioPEEID { get; set; }
        public int DiaID { get; set; }
        public string? Desde { get; set; }
        public string? Hasta { get; set; }
        public string? Color { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
