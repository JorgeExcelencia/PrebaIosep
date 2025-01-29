using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoConsumo
    {
        public int IdTipoConsumo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
