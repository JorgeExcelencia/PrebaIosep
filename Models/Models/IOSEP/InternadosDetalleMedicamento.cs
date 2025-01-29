using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosDetalleMedicamento
    {
        public int IdDetalleMedicamentos { get; set; }
        public int IdInternadoMedicamento { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Dosis { get; set; }
        public decimal Precio { get; set; }
        public string? Factura { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InternadosMedicamento IdInternadoMedicamentoNavigation { get; set; } = null!;
    }
}
