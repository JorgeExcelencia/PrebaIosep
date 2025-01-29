using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterEncabezadoMedicamento
    {
        public InterEncabezadoMedicamento()
        {
            InterDetalleMedicamentos = new HashSet<InterDetalleMedicamento>();
        }

        public int IdEncabezadoMedicamento { get; set; }
        public int IdDetallePresentacion { get; set; }
        public int IdPrescriptor { get; set; }
        public DateTime Fecha { get; set; }
        public bool ACompartida { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InterDetallePresentacion IdDetallePresentacionNavigation { get; set; } = null!;
        public virtual ICollection<InterDetalleMedicamento> InterDetalleMedicamentos { get; set; }
    }
}
