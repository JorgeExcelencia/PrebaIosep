using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Sucursale
    {
        public short IdSucursal { get; set; }
        public string Sucursal { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool? Informatizada { get; set; }
        public bool Anulado { get; set; }
    }
}
