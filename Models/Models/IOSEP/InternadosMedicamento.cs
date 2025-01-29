using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosMedicamento
    {
        public InternadosMedicamento()
        {
            InternadosDetalleMedicamentos = new HashSet<InternadosDetalleMedicamento>();
        }

        public int IdInternadoMedicamento { get; set; }
        public int IdInternado { get; set; }
        public DateTime FechaAdministrado { get; set; }
        public int IdPrescriptor { get; set; }
        public DateTime FechaCrea { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
        public virtual ICollection<InternadosDetalleMedicamento> InternadosDetalleMedicamentos { get; set; }
    }
}
