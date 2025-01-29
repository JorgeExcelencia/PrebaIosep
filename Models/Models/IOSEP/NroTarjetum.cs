using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NroTarjetum
    {
        public long IdNroTarjeta { get; set; }
        public string AfiliadoCuil { get; set; } = null!;
        public string Ano { get; set; } = null!;
        public string? CodigoSeguridad { get; set; }
        public string DigitoVerificador { get; set; } = null!;
    }
}
