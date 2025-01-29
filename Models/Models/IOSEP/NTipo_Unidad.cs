using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NTipo_Unidad
    {
        public int IdTipo_Unidad { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public bool? Anulado { get; set; }
    }
}
