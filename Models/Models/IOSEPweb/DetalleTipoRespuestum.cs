using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class DetalleTipoRespuestum
    {
        public int DetalleTipoRespuestaId { get; set; }
        public int TipoRespuestaId { get; set; }
        public string? Detalle { get; set; }
        public string? ValoraAlmacenar { get; set; }
        public string? ValorMaximo { get; set; }
        public string? ValorMinimo { get; set; }
        public int? TipoValorId { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoRespuestum TipoRespuesta { get; set; } = null!;
        public virtual TipoValor? TipoValor { get; set; }
    }
}
