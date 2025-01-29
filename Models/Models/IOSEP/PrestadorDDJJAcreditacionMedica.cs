using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJAcreditacionMedica
    {
        public int PrestadorDDJJAcreditacionMedicaID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int AcreditacionesMedicaID { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string? NroExpediente { get; set; }

        public virtual AcreditacionesMedica AcreditacionesMedica { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}
