using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VademecumDetalle
    {
        public int IdVademecumDetalle { get; set; }
        public int IdVademecum { get; set; }
        public int Unidades { get; set; }
        public decimal Precio { get; set; }
        public decimal Unitario { get; set; }
        public DateTime Fecha { get; set; }
        public string Laboratorio { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual VademecumFeclise IdVademecumNavigation { get; set; } = null!;
    }
}
