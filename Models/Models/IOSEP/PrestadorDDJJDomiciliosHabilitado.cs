using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJDomiciliosHabilitado
    {
        public int PrestadorDDJJDomiciliosHabilitadosID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int DomiciliosHabiltadosID { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual DomiciliosHabiltado DomiciliosHabiltados { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}
