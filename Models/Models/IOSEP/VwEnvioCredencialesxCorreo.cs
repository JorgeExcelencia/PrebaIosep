using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwEnvioCredencialesxCorreo
    {
        public string AfiliadoNroTarjetaTarEstadoCodigo { get; set; } = null!;
        public DateTime AfiliadoNroTarjetaTarEstadoDesde { get; set; }
        public DateTime AfiliadoNroTarjetaTarEstadoHasta { get; set; }
        public string? Nombre { get; set; }
        public string? Domicilio { get; set; }
        public string? telefono { get; set; }
        public string Documento { get; set; } = null!;
        public string familiar { get; set; } = null!;
        public string AfiliadoCuil { get; set; } = null!;
        public string? UserAC { get; set; }
        public int Numero { get; set; }
        public string a_numero { get; set; } = null!;
        public decimal AfiliadoNroTarjetaNroTarjeta { get; set; }
    }
}
