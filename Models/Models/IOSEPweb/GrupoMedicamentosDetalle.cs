using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class GrupoMedicamentosDetalle
    {
        public int IdGrupoMedicamentosDetalle { get; set; }
        public int IdGrupoMedicamentos { get; set; }
        public int NroRegistro { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
