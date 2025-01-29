using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwDomicilioGrillaDdjj
    {
        public long Iddomicilio { get; set; }
        public int IdAfiliado { get; set; }
        public byte IdTipoDomicilio { get; set; }
        public int? IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public short? IdZona { get; set; }
        public string? Domicilio { get; set; }
        public string? NroPuerta { get; set; }
        public string? Piso { get; set; }
        public string? Departamento { get; set; }
        public string? Torre { get; set; }
        public string? Km { get; set; }
        public string? Detalle { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? Email { get; set; }
        public string CodigoPostal { get; set; } = null!;
        public string Localidad { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public int IdDdjj { get; set; }
    }
}
