using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_DetalleISalud
    {
        public int idDetalle { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string debe_haber { get; set; } = null!;
        public int Idtipo_movimiento { get; set; }
        public int Relacion { get; set; }
        public int RelacionMov { get; set; }
        public bool Cuotas { get; set; }
        public byte? relacion_caja { get; set; }
        public bool ConsultaValorCuota { get; set; }
        public bool OrdenesOnline { get; set; }
        public bool Afiliados { get; set; }
        public bool Empresas { get; set; }
    }
}
