using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoValor
    {
        public TipoValor()
        {
            DetalleTipoRespuesta = new HashSet<DetalleTipoRespuestum>();
            TipoRespuesta = new HashSet<TipoRespuestum>();
        }

        public int TipoValorId { get; set; }
        public string Detalle { get; set; } = null!;
        public string? Tabla { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<DetalleTipoRespuestum> DetalleTipoRespuesta { get; set; }
        public virtual ICollection<TipoRespuestum> TipoRespuesta { get; set; }
    }
}
