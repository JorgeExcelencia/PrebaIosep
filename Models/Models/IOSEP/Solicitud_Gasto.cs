using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Solicitud_Gasto
    {
        public int SolicitudGastoId { get; set; }
        public int OrdenCompraEncabezadoId { get; set; }
        public int? TipoGastoId { get; set; }
        public int? TipoServicioId { get; set; }
        public string Numero_Gasto { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Periodo { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public string Numero_Resolucion { get; set; } = null!;
        public int ProveedorId { get; set; }
        public string? Observaciones { get; set; }
        public decimal? Importe { get; set; }

        public virtual OrdenCompra_Encabezado OrdenCompraEncabezado { get; set; } = null!;
        public virtual Tipo_Gasto? TipoGasto { get; set; }
        public virtual Tipo_Servicio? TipoServicio { get; set; }
    }
}
