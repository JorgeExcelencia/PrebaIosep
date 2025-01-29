using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Reparacion
    {
        public Pat_Reparacion()
        {
            Pat_Reparacion_Detalles = new HashSet<Pat_Reparacion_Detalle>();
        }

        public int IdReparacion { get; set; }
        public int IdProveedor { get; set; }
        public bool Cerrado { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;

        public virtual ICollection<Pat_Reparacion_Detalle> Pat_Reparacion_Detalles { get; set; }
    }
}
