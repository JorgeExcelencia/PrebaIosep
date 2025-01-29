using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPantallasEsquemaRole
    {
        public int RolesId { get; set; }
        public int EsquemaId { get; set; }
        public string Rol { get; set; } = null!;
        public byte Nivel { get; set; }
        public bool Anulado { get; set; }

        public virtual IncPantallasEsquema Esquema { get; set; } = null!;
    }
}
