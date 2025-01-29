using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cotizaciones_Envio
    {
        public Cotizaciones_Envio()
        {
            Cotizaciones_Respuesta = new HashSet<Cotizaciones_Respuestum>();
        }

        public int IdCotizaciones_Envio { get; set; }
        public int IdCotizaciones_Pedido { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public DateTime Fecha_Respuesta { get; set; }
        public string Envio_mail { get; set; } = null!;
        public DateTime Fecha_envio { get; set; }
        public string Presupuesto_Nro { get; set; } = null!;
        public string Usuario_Respuesta { get; set; } = null!;

        public virtual ICollection<Cotizaciones_Respuestum> Cotizaciones_Respuesta { get; set; }
    }
}
