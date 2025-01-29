using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Turno
    {
        public Turno()
        {
            AfiliadoDatos = new HashSet<AfiliadoDato>();
        }

        public int TurnoId { get; set; }
        public int TurnoNro { get; set; }
        public decimal? TurnoAfiliadoCuil { get; set; }
        public DateTime TurnoFechaTurno { get; set; }
        public string TurnoHoraTurno { get; set; } = null!;
        public DateTime? TurnoFechaAsignacion { get; set; }
        public DateTime? TurnoFechaAtencion { get; set; }
        public decimal? TurnoUsuarioCuilAtencion { get; set; }
        public DateTime? TurnoFechaAnulacion { get; set; }
        public string Estado { get; set; } = null!;

        public virtual ICollection<AfiliadoDato> AfiliadoDatos { get; set; }
    }
}
