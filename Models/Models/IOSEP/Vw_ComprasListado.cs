using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_ComprasListado
    {
        public long? IdCotizaciones_Envio { get; set; }
        public int? IdProveedor { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Comprobante { get; set; }
        public int? IdComprasTipo { get; set; }
        public string? Resolucion { get; set; }
        public int? IdCotizaciones_Pedido { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Nombre { get; set; }
        public string? Presentacion { get; set; }
        public string? Monodroga { get; set; }
    }
}
