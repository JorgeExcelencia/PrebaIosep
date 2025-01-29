using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DiagnosticoRelacionadoDetalle
    {
        public int IdDiagnosticoDetalle { get; set; }
        public int IdDiagnosticoRelacionado { get; set; }
        public int NroRegistro { get; set; }
        public int IdNomen_General { get; set; }
        public bool Anulado { get; set; }
    }
}
