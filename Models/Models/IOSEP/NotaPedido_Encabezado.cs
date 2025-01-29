using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotaPedido_Encabezado
    {
        public NotaPedido_Encabezado()
        {
            NotaPedido_Detalles = new HashSet<NotaPedido_Detalle>();
            NotaPedido_Presupuestos = new HashSet<NotaPedido_Presupuesto>();
            NotaPedido_Proveedores = new HashSet<NotaPedido_Proveedore>();
        }

        public int NotaPedidoEncabezadoId { get; set; }
        public string Numero_NotaDePedido { get; set; } = null!;
        public string Anio { get; set; } = null!;
        public int TipoNotadePedidoId { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FecHoraApertura { get; set; }
        public decimal EstimativoTotal { get; set; }
        public string Asunto { get; set; } = null!;
        public int EstadoNotaDePedidoId { get; set; }
        public string Observaciones { get; set; } = null!;
        public bool Extra_Presupuesto { get; set; }
        public int Solicita_SectorId { get; set; }
        public int Destino_SectorId { get; set; }
        public int CuentaContableId { get; set; }
        public bool Remito { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual Cuentas_Contable CuentaContable { get; set; } = null!;
        public virtual Estado_NotaDePedido EstadoNotaDePedido { get; set; } = null!;
        public virtual Tipo_NotaDePedido TipoNotadePedido { get; set; } = null!;
        public virtual ICollection<NotaPedido_Detalle> NotaPedido_Detalles { get; set; }
        public virtual ICollection<NotaPedido_Presupuesto> NotaPedido_Presupuestos { get; set; }
        public virtual ICollection<NotaPedido_Proveedore> NotaPedido_Proveedores { get; set; }
    }
}
