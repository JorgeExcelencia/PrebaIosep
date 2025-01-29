using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EmpresasAfiliadosDDJJ
    {
        public int IdEmpresasAfiliadosDDJJ { get; set; }
        public int IdDDJJ { get; set; }
        public int IdEmpresa { get; set; }
        public decimal? ContratoLocacion { get; set; }
        public decimal CuotaAfiliado { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? OpCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual AfiliadosDDJJ IdDDJJNavigation { get; set; } = null!;
        public virtual Empresas_IosepSalud IdEmpresaNavigation { get; set; } = null!;
    }
}
