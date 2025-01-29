using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_CtaCteAfiliados2
    {
        public int IdAfiliado { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string? Numero_Comprobante { get; set; }
        public string Periodo { get; set; } = null!;
        public DateTime Fecha_Vencimiento1 { get; set; }
        public DateTime Fecha_Vencimiento2 { get; set; }
        public decimal Importe_Vencimiento2 { get; set; }
        public decimal Importe_Total { get; set; }
        public byte? Cantidad_Cuotas { get; set; }
        public string? Cupon_Coseguro { get; set; }
        public string Documento { get; set; } = null!;
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdCtaCteIosep { get; set; }
        public decimal Importe_Vencimiento1 { get; set; }
        public string? Tipo_Detalle { get; set; }
        public string? Tipo_DetalleCuenta { get; set; }
        public string? Tipo_Movimiento { get; set; }
        public string? Tipo_MovimientoCuenta { get; set; }
        public short IdDetalle { get; set; }
        public int IdTipo_Movimiento { get; set; }
        public int? Relacion { get; set; }
        public int? RelacionMov { get; set; }
        public int? Pagada { get; set; }
        public int? IdPresupuesto { get; set; }
        public string? Domicilio { get; set; }
        public string? NroPuerta { get; set; }
        public string? Piso { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Localidad { get; set; }
        public string? A_Numero { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string? Barrio { get; set; }
    }
}
