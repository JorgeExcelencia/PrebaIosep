using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SituacionTributarium
    {
        public SituacionTributarium()
        {
            Personas = new HashSet<Persona>();
        }

        public short SituacionTribID { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? Iva { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
