using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AfiliadoDato
    {
        public int TurnoId { get; set; }
        public decimal AfiliadoDatoCuil { get; set; }
        public string? AfiliadoDatoemail { get; set; }
        public string? AfiliadoDatocelular { get; set; }
        public string? AfiliadoDatotelefono { get; set; }

        public virtual Turno Turno { get; set; } = null!;
    }
}
