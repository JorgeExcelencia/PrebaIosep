using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PrefijoAlias
    {
        public int PrefijoAliasId { get; set; }
        public string Prefijo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
