using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Personas_TipoDetalle
    {
        public int TipoDetalleID { get; set; }
        public int PersonaID { get; set; }
        public byte TipoPersonaID { get; set; }
        public int? TablaID { get; set; }
        public bool Anulado { get; set; }

        public virtual Persona Persona { get; set; } = null!;
        public virtual Persona_Tipo TipoPersona { get; set; } = null!;
    }
}
