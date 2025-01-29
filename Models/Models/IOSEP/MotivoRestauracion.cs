using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoRestauracion
    {
        public int MotivoRestauracionID { get; set; }
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }
    }
}
