using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoPresentacion
    {
        public int IdTipoPresentacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
