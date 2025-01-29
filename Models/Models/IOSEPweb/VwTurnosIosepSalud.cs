using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwTurnosIosepSalud
    {
        public int TurnoNro { get; set; }
        public decimal? TurnoAfiliadoCuil { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime TurnoFechaTurno { get; set; }
        public string Estado { get; set; } = null!;
    }
}
