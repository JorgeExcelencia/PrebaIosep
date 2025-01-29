using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_VistaCobrosBanco
    {
        public string sucursal { get; set; } = null!;
        public string comprobante { get; set; } = null!;
        public decimal importe { get; set; }
        public DateTime fecha_cobro { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string? A_Numero { get; set; }
        public string? Numero_Comprobante { get; set; }
        public short IdDetalle { get; set; }
        public string Periodo { get; set; } = null!;
        public decimal Importe_Total { get; set; }
        public int? Pagada { get; set; }
        public bool Anulado { get; set; }
        public string? Paga_Comprobante_Nro { get; set; }
        public int IdIosepSaludBanco { get; set; }
        public int idCtaCteIosep { get; set; }
        public string CuilTitular { get; set; } = null!;
        public string Nombre { get; set; } = null!;
    }
}
