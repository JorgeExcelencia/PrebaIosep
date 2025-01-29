using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_CtaCteAfiliadosDH
    {
        public int IdAfiliado { get; set; }
        public DateTime fecha_emision { get; set; }
        public string numero_comprobante { get; set; } = null!;
        public string periodo { get; set; } = null!;
        public DateTime Fecha_vencimiento1 { get; set; }
        public DateTime Fecha_vencimiento2 { get; set; }
        public decimal Importe_vencimiento2 { get; set; }
        public decimal Importe_total { get; set; }
        public byte Cantidad_Cuotas { get; set; }
        public string Cupon_coseguro { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public int idCtaCteIosep { get; set; }
        public decimal Importe_Vencimiento1 { get; set; }
        public string? Tipo_Detalle { get; set; }
        public string? Tipo_DetalleCuenta { get; set; }
        public string? Tipo_Movimiento { get; set; }
        public string? Tipo_MovimientoCuenta { get; set; }
        public string cuil { get; set; } = null!;
        public short iddetalle { get; set; }
        public short idtipo_movimiento { get; set; }
        public int? Relacion { get; set; }
        public int? RelacionMov { get; set; }
        public int Pagada { get; set; }
        public int IdPresupuesto { get; set; }
        public int? IdPago { get; set; }
    }
}
