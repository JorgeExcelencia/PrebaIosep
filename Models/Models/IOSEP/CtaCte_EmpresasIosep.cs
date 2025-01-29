using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CtaCte_EmpresasIosep
    {
        public int idEmpresaCtaCte { get; set; }
        public int idEmpresa { get; set; }
        public DateTime fecha_emision { get; set; }
        public string? numero_comprobante { get; set; }
        public short iddetalle { get; set; }
        public short idtipo_movimiento { get; set; }
        public string periodo { get; set; } = null!;
        public DateTime fecha_vencimiento1 { get; set; }
        public decimal importe_vencimiento1 { get; set; }
        public DateTime fecha_vencimiento2 { get; set; }
        public decimal importe_vencimiento2 { get; set; }
        public int cantidad_afiliados { get; set; }
        public int pagada { get; set; }
        public decimal cuota_afiliado { get; set; }
        public decimal Importe_Total { get; set; }
        public bool anulado { get; set; }
        public string? codbarra { get; set; }
        public int? idctacte { get; set; }
        public string? paga_comprobante { get; set; }
    }
}
