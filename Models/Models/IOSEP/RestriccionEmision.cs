using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RestriccionEmision
    {
        public int IdRestriccionEmision { get; set; }
        public int IdDelegacion { get; set; }
        public bool Consulta { get; set; }
        public bool CoseguroConsulta { get; set; }
        public bool Monodroga { get; set; }
        public bool CoseguroMonodroga { get; set; }
        public bool Practicas { get; set; }
        public bool CoseguroPracticas { get; set; }
        public bool Prestador { get; set; }
        public bool Diagnostico { get; set; }
        public bool OtrosPlanes { get; set; }
        public bool? ImprimeGrupoFamiliar { get; set; }
        public bool Anulado { get; set; }
    }
}
