using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AnamnesisRespuesta
    {
        public int AnamnesisRespuestasId { get; set; }
        public int TipoRespuestaId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
