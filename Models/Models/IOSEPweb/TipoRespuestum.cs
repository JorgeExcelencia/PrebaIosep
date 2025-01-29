using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoRespuestum
    {
        public TipoRespuestum()
        {
            AnamnesisDetalles = new HashSet<AnamnesisDetalle>();
            DetalleTipoRespuesta = new HashSet<DetalleTipoRespuestum>();
        }

        public int TipoRespuestaId { get; set; }
        public string Detalle { get; set; } = null!;
        public string? ValoraAlmacenar { get; set; }
        public string? ValoraMostrar { get; set; }
        public string? Observaciones { get; set; }
        public int TipoValorId { get; set; }
        public string? TablaExterna { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoValor TipoValor { get; set; } = null!;
        public virtual ICollection<AnamnesisDetalle> AnamnesisDetalles { get; set; }
        public virtual ICollection<DetalleTipoRespuestum> DetalleTipoRespuesta { get; set; }
    }
}
