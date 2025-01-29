using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Zona
    {
        public Zona()
        {
            Domicilios = new HashSet<Domicilio>();
            DomiciliosDDJJs = new HashSet<DomiciliosDDJJ>();
        }

        public short idzona { get; set; }
        public string? codigo { get; set; }
        public string nombre { get; set; } = null!;
        public bool anulado { get; set; }

        public virtual ICollection<Domicilio> Domicilios { get; set; }
        public virtual ICollection<DomiciliosDDJJ> DomiciliosDDJJs { get; set; }
    }
}
