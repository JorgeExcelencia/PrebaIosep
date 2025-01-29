using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ImpresionOrdene
    {
        public int IdImpresion { get; set; }
        public string Usuario { get; set; } = null!;
        public byte[]? Pdf { get; set; }
    }
}
