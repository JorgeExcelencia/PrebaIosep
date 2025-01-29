using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Sexo
    {
        public byte IdSexo { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
