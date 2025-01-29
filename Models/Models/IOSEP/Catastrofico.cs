using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Catastrofico
    {
        public int IdCatastrofico { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
