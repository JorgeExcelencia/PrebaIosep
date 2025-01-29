using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Domicilio
    {
        public long IdDomicilio { get; set; }
        public int IdAfiliado { get; set; }
        public byte IdTipoDomicilio { get; set; }
        public int? IdLocalidad { get; set; }
        public short? IdZona { get; set; }
        public string? Domicilio1 { get; set; }
        public string? Barrio { get; set; }
        public string? NroPuerta { get; set; }
        public string? Piso { get; set; }
        public string? Departamento { get; set; }
        public string? Torre { get; set; }
        public string? MZA { get; set; }
        public string? Lote { get; set; }
        public string? Km { get; set; }
        public string? Detalle { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? Email { get; set; }
        public bool Anulado { get; set; }
        public string? TelefonoReferencia { get; set; }

        public virtual Localidade? IdLocalidadNavigation { get; set; }
        public virtual TipoDomicilio IdTipoDomicilioNavigation { get; set; } = null!;
        public virtual Zona? IdZonaNavigation { get; set; }
    }
}
