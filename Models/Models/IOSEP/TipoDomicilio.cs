using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoDomicilio
    {
        public TipoDomicilio()
        {
            Domicilios = new HashSet<Domicilio>();
            DomiciliosDDJJs = new HashSet<DomiciliosDDJJ>();
        }

        public byte idtipodomicilio { get; set; }
        public string nombre { get; set; } = null!;
        public bool anulado { get; set; }

        public virtual ICollection<Domicilio> Domicilios { get; set; }
        public virtual ICollection<DomiciliosDDJJ> DomiciliosDDJJs { get; set; }
    }
}
