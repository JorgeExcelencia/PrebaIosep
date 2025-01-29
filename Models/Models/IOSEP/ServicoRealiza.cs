using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ServicoRealiza
    {
        public ServicoRealiza()
        {
            PrestadorDDJJServicioRealizas = new HashSet<PrestadorDDJJServicioRealiza>();
        }

        public int ServicoRealizaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJServicioRealiza> PrestadorDDJJServicioRealizas { get; set; }
    }
}
