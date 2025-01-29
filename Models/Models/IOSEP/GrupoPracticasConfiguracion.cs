using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoPracticasConfiguracion
    {
        public int IdGrupoPracticasConfiguracion { get; set; }
        public int IdGrupoPractica { get; set; }
        public bool CambioCentroAmbC { get; set; }
        public bool CambioCentroAmbCyS { get; set; }
        public bool CambioCentroIntCyS { get; set; }
        public bool CambioCentroIntC { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
