using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PedidoInterno_Encabezado
    {
        public PedidoInterno_Encabezado()
        {
            PedidoInterno_Detalles = new HashSet<PedidoInterno_Detalle>();
        }

        public int PedidoInternoEncabezadoId { get; set; }
        public string Numero_PedidoInterno { get; set; } = null!;
        public string Anio { get; set; } = null!;
        public int TipoPedidoInternoId { get; set; }
        public string? Remito_Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? EstimativoTotal { get; set; }
        public string? Observaciones { get; set; }
        public int Solicita_SectorId { get; set; }
        public int Destino_SectorId { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual Sectores_Iosep Destino_Sector { get; set; } = null!;
        public virtual Sectores_Iosep Solicita_Sector { get; set; } = null!;
        public virtual Tipo_PedidoInterno TipoPedidoInterno { get; set; } = null!;
        public virtual ICollection<PedidoInterno_Detalle> PedidoInterno_Detalles { get; set; }
    }
}
