using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorEstadoHistorico
    {
        public int PrestadorEstadoHistoricoID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int PrestadorEstadoID { get; set; }
        public DateTime Fecha { get; set; }
        public string? Usuario { get; set; }

        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
        public virtual PrestadorEstado PrestadorEstado { get; set; } = null!;
    }
}
