using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwDomicilio
    {
        public long Iddomicilio { get; set; }
        public int Idafiliado { get; set; }
        public byte Idtipodomicilio { get; set; }
        public string TipoDomicilio { get; set; } = null!;
        public string? Pais { get; set; }
        public string? Provincia { get; set; }
        public string? Localidad { get; set; }
        public short? Idzona { get; set; }
        public string? Zona { get; set; }
        public string? domicilio { get; set; }
        public string? nropuerta { get; set; }
        public string? departamento { get; set; }
        public string? torre { get; set; }
        public string? km { get; set; }
        public string? detalle { get; set; }
        public string? telefonofijo { get; set; }
        public string? telefonocelular { get; set; }
        public string? email { get; set; }
        public bool anulado { get; set; }
        public int? Idprovincia { get; set; }
        public int? idpais { get; set; }
        public int? Idlocalidad { get; set; }
        public string? codigopostal { get; set; }
        public string? piso { get; set; }
    }
}
