using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class empresa_afiliado
    {
        public empresa_afiliado()
        {
            empresaLogs = new HashSet<empresaLog>();
        }

        public int ID { get; set; }
        public int IdEmpresa { get; set; }
        public int IdAfiliado { get; set; }
        public bool EsTitular { get; set; }
        public decimal CuotaAfiliado { get; set; }
        public string Estado { get; set; } = null!;
        public string? Motivo { get; set; }
        public bool Anulado { get; set; }

        public virtual empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual ICollection<empresaLog> empresaLogs { get; set; }
    }
}
