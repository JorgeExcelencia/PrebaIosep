using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadoNroTarjetaTarEstado
    {
        public long IdAfiNroTarEst { get; set; }
        public string AfiliadoCuil { get; set; } = null!;
        public decimal AfiliadoNroTarjetaNroTarjeta { get; set; }
        public string AfiliadoNroTarjetaTarEstadoCodigo { get; set; } = null!;
        public DateTime AfiliadoNroTarjetaTarEstadoDesde { get; set; }
        public DateTime AfiliadoNroTarjetaTarEstadoHasta { get; set; }
        public string? AfiliadoNroTarjetaTarEstadoMotivo { get; set; }
        public string? UserAC { get; set; }
        public string? Machine { get; set; }
        public string? Nombre { get; set; }
        public string? Familiar { get; set; }
        public bool? ImpresoPorIosep { get; set; }
        public string? UserSave { get; set; }
        public string? UserMod { get; set; }
        public int Numero { get; set; }
    }
}
