using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NTipo_Practica
    {
        public int IdTipo_Practica { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
