using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Generado_Lugar
    {
        public short idGenerado { get; set; }
        public short Codigo { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
