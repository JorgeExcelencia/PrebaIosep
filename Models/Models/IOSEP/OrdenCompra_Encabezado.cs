using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenCompra_Encabezado
    {
        public OrdenCompra_Encabezado()
        {
            OrdenCompra_Comprobantes = new HashSet<OrdenCompra_Comprobante>();
        }

        public int OrdenCompraEncabezadoId { get; set; }
        public string Numero_OrdenCompra { get; set; } = null!;
        public string Anio { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Numero_Expediente { get; set; }
        public string Numero_Comprobante { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public decimal Importe_Total { get; set; }
        public int CuentaContableId { get; set; }
        public string Resolucion { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual Cuentas_Contable CuentaContable { get; set; } = null!;
        public virtual ICollection<OrdenCompra_Comprobante> OrdenCompra_Comprobantes { get; set; }
    }
}
