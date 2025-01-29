using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ResultadoDiagnostico
    {
        public int ResultadoDiagnosticoID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Digitalizar { get; set; }
        public bool Anulado { get; set; }
    }
}
