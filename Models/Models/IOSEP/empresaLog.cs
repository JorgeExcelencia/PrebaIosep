using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class empresaLog
    {
        public int IdEmpresaLog { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdEmpAfi { get; set; }
        public string Operador { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Operacion { get; set; }

        public virtual empresa_afiliado? IdEmpAfiNavigation { get; set; }
        public virtual empresa IdEmpresaNavigation { get; set; } = null!;
    }
}
