using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ArchivosSitaci
    {
        public int IdArchivo { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int LongitudFile { get; set; }
        public bool? Habilitado { get; set; }
        public bool Anulado { get; set; }
    }
}
