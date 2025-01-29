using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Empresas_Afiliado
    {
        public int IdEmpresaAfiliados { get; set; }
        public int IdEmpresa { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public DateTime FechaCarga { get; set; }
        public decimal CuotaAfiliado { get; set; }
        public bool Suspendido { get; set; }
        public bool Inhabilitado { get; set; }
    }
}
