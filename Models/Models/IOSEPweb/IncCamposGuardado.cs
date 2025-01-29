using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncCamposGuardado
    {
        public int CamposGuardadosId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public int CampoId { get; set; }
        public string? Texto { get; set; }
        public string? Valor { get; set; }
        public bool Anulado { get; set; }

        public virtual IncCampo Campo { get; set; } = null!;
        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
    }
}
