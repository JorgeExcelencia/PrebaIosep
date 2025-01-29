using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CondicionAfiliado
    {
        public long IdCondicion { get; set; }
        public int IdAfiliado { get; set; }
        public short IdTipoCondicion { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string? Resolucion { get; set; }
        public string? Expediente { get; set; }
        public string? Observaciones { get; set; }
        public bool? Anulado { get; set; }

        public virtual TipoCondicion IdTipoCondicionNavigation { get; set; } = null!;
    }
}
