using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Empresas_Dato
    {
        public int? Cantidad_Afiliados { get; set; }
        public decimal? Suma_Cuotas { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Resolucion { get; set; } = null!;
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime renovar_el { get; set; }
        public string CUIT { get; set; } = null!;
        public decimal CuotaAfiliado { get; set; }
        public int IdEmpresa { get; set; }
    }
}
