using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwDiagnostico
    {
        public int IdDiagnostico { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte Capitulo { get; set; }
        public string NombreCapitulo { get; set; } = null!;
    }
}
