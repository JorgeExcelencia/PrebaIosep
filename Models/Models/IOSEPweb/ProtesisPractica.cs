using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ProtesisPractica
    {
        public int ProtesisId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Familia { get; set; }
        public int? GrupoId { get; set; }
        public bool VademecumIosep { get; set; }
        public bool Anulado { get; set; }

        public virtual ProtesisGrupo? Grupo { get; set; }
    }
}
