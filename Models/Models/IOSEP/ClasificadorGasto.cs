using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ClasificadorGasto
    {
        public ClasificadorGasto()
        {
            Orden_Pagos = new HashSet<Orden_Pago>();
        }

        public int ClasificadorGastosID { get; set; }
        public string? Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public int SumarizaId { get; set; }
        public byte? Nivel { get; set; }
        public string? Observaciones { get; set; }
        public bool Aplicable { get; set; }
        public bool Anulada { get; set; }

        public virtual ICollection<Orden_Pago> Orden_Pagos { get; set; }
    }
}
