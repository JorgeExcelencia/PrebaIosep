using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Reintegro
    {
        public Tipo_Reintegro()
        {
            Reintegros_Encabezados = new HashSet<Reintegros_Encabezado>();
        }

        public int TipoReintegroID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Reintegros_Encabezado> Reintegros_Encabezados { get; set; }
    }
}
