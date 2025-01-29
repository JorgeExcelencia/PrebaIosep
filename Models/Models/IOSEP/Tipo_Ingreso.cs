using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Ingreso
    {
        public Tipo_Ingreso()
        {
            Ingresos = new HashSet<Ingreso>();
        }

        public int TipoIngresoId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Ingreso> Ingresos { get; set; }
    }
}
