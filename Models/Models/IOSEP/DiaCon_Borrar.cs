using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DiaCon_Borrar
    {
        public int DiagnosticosConsultasID { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public bool Anulado { get; set; }
    }
}
