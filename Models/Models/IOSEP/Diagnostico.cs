using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Diagnostico
    {
        public Diagnostico()
        {
            Encabezado_Autorizaciones = new HashSet<Encabezado_Autorizacione>();
            Internados = new HashSet<Internado>();
        }

        public int IdDiagnostico { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Consultas { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; }
        public virtual ICollection<Internado> Internados { get; set; }
    }
}
