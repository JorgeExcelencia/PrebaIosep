using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DiagnosticoRelacionado
    {
        public int IdDiagnosticoRelacionado { get; set; }
        public int IdCapitulo { get; set; }
        public string IdDiagnostico { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
