using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Orden
    {
        public int IdTipo_Orden { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public byte? Internado { get; set; }
        public bool anulado { get; set; }
    }
}
