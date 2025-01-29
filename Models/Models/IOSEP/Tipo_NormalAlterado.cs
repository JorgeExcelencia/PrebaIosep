using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_NormalAlterado
    {
        public int NormalAlteradoID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
