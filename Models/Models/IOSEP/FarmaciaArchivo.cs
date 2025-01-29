using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class FarmaciaArchivo
    {
        public int IdFarmaciaArchivos { get; set; }
        public string NombreArchivo { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
