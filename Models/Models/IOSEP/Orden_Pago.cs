using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Orden_Pago
    {
        public Orden_Pago()
        {
            OrdenPago_Anticipos = new HashSet<OrdenPago_Anticipo>();
            OrdenPago_Beneficiarios = new HashSet<OrdenPago_Beneficiario>();
            OrdenPago_CuentaContables = new HashSet<OrdenPago_CuentaContable>();
            OrdenPago_DetalleCheques = new HashSet<OrdenPago_DetalleCheque>();
            OrdenPago_Retenciones = new HashSet<OrdenPago_Retencione>();
        }

        public int OrdenPagoID { get; set; }
        public int OrdenCompraComprobanteID { get; set; }
        public int ClasificadorGastosID { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public string Referencia_Expediente { get; set; } = null!;
        public string Numero_OrdenPago { get; set; } = null!;
        public string Anio { get; set; } = null!;
        public string CuilProveedor { get; set; } = null!;
        public string? Beneficiario { get; set; }
        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }
        public decimal Importe_Neto { get; set; }
        public decimal Importe_Retenido { get; set; }
        public decimal Importe_Anticipos { get; set; }
        public decimal Importe_Pagado { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FechaHoraCrea { get; set; }
        public DateTime? Vencimiento { get; set; }
        public bool Aprobado { get; set; }
        public DateTime? Fecha_ATesoreria { get; set; }
        public bool A_Tesoreria { get; set; }
        public bool? Existente { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public string? MotivoAnulacion { get; set; }
        public int? TipoOrdenPagoID { get; set; }
        public bool Anulado { get; set; }

        public virtual ClasificadorGasto ClasificadorGastos { get; set; } = null!;
        public virtual TipoOrdenPago? TipoOrdenPago { get; set; }
        public virtual ICollection<OrdenPago_Anticipo> OrdenPago_Anticipos { get; set; }
        public virtual ICollection<OrdenPago_Beneficiario> OrdenPago_Beneficiarios { get; set; }
        public virtual ICollection<OrdenPago_CuentaContable> OrdenPago_CuentaContables { get; set; }
        public virtual ICollection<OrdenPago_DetalleCheque> OrdenPago_DetalleCheques { get; set; }
        public virtual ICollection<OrdenPago_Retencione> OrdenPago_Retenciones { get; set; }
    }
}
