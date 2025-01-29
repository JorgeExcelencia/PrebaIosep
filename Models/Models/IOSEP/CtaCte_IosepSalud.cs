using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CtaCte_IosepSalud
    {
        public int IdCtaCteIosep { get; set; }
        public int? IdCtaCte { get; set; }
        public int? IdEmpresa { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string? A_Numero { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string? Numero_Comprobante { get; set; }
        public short IdDetalle { get; set; }
        public int IdTipo_Movimiento { get; set; }
        public string Periodo { get; set; } = null!;
        public DateTime Fecha_Vencimiento1 { get; set; }
        public decimal Importe_Vencimiento1 { get; set; }
        public DateTime Fecha_Vencimiento2 { get; set; }
        public decimal Importe_Vencimiento2 { get; set; }
        public decimal Importe_Total { get; set; }
        public byte? Cantidad_Cuotas { get; set; }
        public string? Cupon_Coseguro { get; set; }
        /// <summary>
        /// 0 = no esta pagada, Si es Nro &lt;&gt; 0 es el idCtaCtaIosep de la factura que se paga
        /// </summary>
        public int? Pagada { get; set; }
        /// <summary>
        /// Para Vincular con Prsupuesto, Campo IdCajaClinica de la tabla CajaClinicas
        /// </summary>
        public int? IdPresupuesto { get; set; }
        public string? Paga_Comprobante_Nro { get; set; }
        public byte? Boletas { get; set; }
        public bool Anulado { get; set; }
    }
}
