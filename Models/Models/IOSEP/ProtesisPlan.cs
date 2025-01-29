using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisPlan
    {
        public int ProtesisPlanID { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlanes_Afiliado { get; set; }
        public int PlanID { get; set; }
        public int EsquemaID { get; set; }
        public int Cantidad { get; set; }
        public decimal Cobertura { get; set; }
        public int NroRegistro { get; set; }
        public string? Descripcion { get; set; }
        public string? Observaciones { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
