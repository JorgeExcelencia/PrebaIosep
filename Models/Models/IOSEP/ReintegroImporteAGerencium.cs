using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReintegroImporteAGerencium
    {
        public int ImporteAGerenciaID { get; set; }
        public DateTime FechaDesde { get; set; }
        public decimal Importe { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
    }
}
