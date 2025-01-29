using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterClinicaFactura
    {
        public int IdClinicaFactura { get; set; }
        public int EncabezadoId { get; set; }
        public int IdClinica { get; set; }
        public string Factura { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InterEncabezadoPresentacion Encabezado { get; set; } = null!;
    }
}
