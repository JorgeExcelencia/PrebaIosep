using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_CtaCteEmpresa
    {
        public int idEmpresa { get; set; }
        public string? numero_comprobante { get; set; }
        public short iddetalle { get; set; }
        public string periodo { get; set; } = null!;
        public DateTime fecha_vencimiento1 { get; set; }
        public decimal importe_vencimiento1 { get; set; }
        public DateTime fecha_vencimiento2 { get; set; }
        public decimal importe_vencimiento2 { get; set; }
        public int idEmpresaCtaCte { get; set; }
        public DateTime fecha_emision { get; set; }
        public string? Nombre { get; set; }
        public string? Domicilio { get; set; }
        public string? CUIT { get; set; }
        public string? Tipo_Detalle { get; set; }
        public string? Tipo_DetalleCuenta { get; set; }
        public string? Tipo_Movimiento { get; set; }
        public string? Tipo_MovimientoCuenta { get; set; }
        public int? Relacion { get; set; }
        public int? RelacionMov { get; set; }
        public short idtipo_movimiento { get; set; }
        public int pagada { get; set; }
        public int cantidad_afiliados { get; set; }
        public decimal cuota_afiliado { get; set; }
        public decimal? cuota_afiliado_actual { get; set; }
        public decimal Importe_Total { get; set; }
        public string? CodigoBarra { get; set; }
    }
}
