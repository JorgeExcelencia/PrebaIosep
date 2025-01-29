using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Turnos_Bloqueo
    {
        public long IdBloqueo { get; set; }
        public int IdTurnos { get; set; }
        public DateTime CheckIN { get; set; }
        public DateTime? CheckOUT { get; set; }
    }
}
