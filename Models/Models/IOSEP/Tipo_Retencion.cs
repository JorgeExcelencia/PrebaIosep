using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Retencion
    {
        public Tipo_Retencion()
        {
            OrdenPago_Retenciones = new HashSet<OrdenPago_Retencione>();
        }

        public int TipoRetencionID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal? Importe_Minimo { get; set; }
        public decimal? Procentaje_Retencion { get; set; }
        public decimal? Alicuota_Basica { get; set; }
        public decimal? Importe_Incremento { get; set; }
        public decimal? Alicuota_Incremento { get; set; }
        public decimal? Importe_Maximo { get; set; }
        public decimal? Alicuota_Maxima { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<OrdenPago_Retencione> OrdenPago_Retenciones { get; set; }
    }
}
