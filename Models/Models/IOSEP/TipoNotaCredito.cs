using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoNotaCredito
    {
        public TipoNotaCredito()
        {
            DetalleNotaDeCreditos = new HashSet<DetalleNotaDeCredito>();
        }

        public int TipoNotaCreditoID { get; set; }
        public string Descripcion { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<DetalleNotaDeCredito> DetalleNotaDeCreditos { get; set; }
    }
}
