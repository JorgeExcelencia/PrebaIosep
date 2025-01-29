using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanUsuario
    {
        public int PlanUsuarioID { get; set; }
        public int PlanId { get; set; }
        public string UsuarioID { get; set; } = null!;
        public string OperadorCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperadorMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? OperadorAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
