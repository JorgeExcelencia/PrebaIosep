using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Siniestro
    {
        public int SiniestroID { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlanes_Afiliado { get; set; }
        public int IdPlan { get; set; }
        public int EsquemaID { get; set; }
        public string NroSiniestro { get; set; } = null!;
        public DateTime FechaSiniestro { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCarga { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
