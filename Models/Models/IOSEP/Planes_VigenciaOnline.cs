using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Planes_VigenciaOnline
    {
        public int VigenciaOnlineID { get; set; }
        public int PlanID { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public DateTime? VigenciaHasta { get; set; }
    }
}
