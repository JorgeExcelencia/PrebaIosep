using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Persona_Tipo
    {
        public Persona_Tipo()
        {
            Personas_TipoDetalles = new HashSet<Personas_TipoDetalle>();
        }

        public byte TipoPersonaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Tabla { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Personas_TipoDetalle> Personas_TipoDetalles { get; set; }
    }
}
