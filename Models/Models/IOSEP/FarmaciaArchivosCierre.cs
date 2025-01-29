using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class FarmaciaArchivosCierre
    {
        public int IdFarmaciaArchivosCierre { get; set; }
        public int IdFarmaciaArchivos { get; set; }
        public string IdCaratula { get; set; } = null!;
        public int IdFarmacia { get; set; }
        public string NombreFarmacia { get; set; } = null!;
        public int IdConvenio { get; set; }
        public string NombreConvenio { get; set; } = null!;
        public int IdPlan { get; set; }
        public string NombrePlan { get; set; } = null!;
        public DateTime FechaCierre { get; set; }
        public int CantidadRecetas { get; set; }
        public decimal ImporteRecetas { get; set; }
        public decimal ImporteCargoObraSocial { get; set; }
        public decimal ImporteCargoAfiliado { get; set; }
        public string NumeroAutorizacion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
