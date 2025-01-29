using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwTurnosMedico
    {
        public int IdPrestador { get; set; }
        public string Matricula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Dia { get; set; } = null!;
        public string Desde { get; set; } = null!;
        public string Hasta { get; set; } = null!;
        public short Incremento { get; set; }
    }
}
