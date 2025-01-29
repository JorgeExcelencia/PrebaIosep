using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwHistorialMedicamento
    {
        public int IdEncabezado_Venta { get; set; }
        public int? IdAfiliado { get; set; }
        public DateTime Fecha { get; set; }
        public string Numero_Comprobante { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string? DetalleMedicacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio_venta { get; set; }
        public decimal? Reconoce { get; set; }
        public decimal Coseguro { get; set; }
        public int NroRegistro { get; set; }
        public int? NuevaDro { get; set; }
        public string? Descripcion { get; set; }
        public int IdDetalle_Ventas { get; set; }
        public string? Encabezado { get; set; }
        public decimal? MontoTotal { get; set; }
    }
}
