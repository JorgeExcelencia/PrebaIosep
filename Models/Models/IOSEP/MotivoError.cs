using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoError
    {
        public int MotivoErrorID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
