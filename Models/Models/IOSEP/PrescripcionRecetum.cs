using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrescripcionRecetum
    {
        public int IdPrescripcionReceta { get; set; }
        public int IdPrescripcionElectronica { get; set; }
        public string Hash { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Numero { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
