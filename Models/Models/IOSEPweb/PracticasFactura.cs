using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracticasFactura
    {
        public int IdPracticasFacturas { get; set; }
        public int EncabezadoId { get; set; }
        public int IdClinica { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public string? Cae { get; set; }
        public string? Cuit { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
