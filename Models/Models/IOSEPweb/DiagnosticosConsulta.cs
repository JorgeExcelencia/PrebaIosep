using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class DiagnosticosConsulta
    {
        public int DiagnosticosConsultasId { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public bool Anulado { get; set; }
    }
}
