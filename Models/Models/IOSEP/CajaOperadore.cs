using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CajaOperadore
    {
        public int IdCaja { get; set; }
        public short IdLugar { get; set; }
        public DateTime Fecha { get; set; }
        public short IdTipoCaja { get; set; }
        public int? IdAutoriza { get; set; }
        public decimal Importe { get; set; }
        public short Cantidad { get; set; }
        public short IdFormaPago { get; set; }
        public decimal Pagado { get; set; }
        public int IdConcepto { get; set; }
        public string Cajero { get; set; } = null!;
        public int IdCierreCaja { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public string? numero_comprobante { get; set; }
        public string? comprobante_original { get; set; }
        public int? IdAfiliado { get; set; }
        public string? Sucursal { get; set; }

        public virtual CajaCierre IdCierreCajaNavigation { get; set; } = null!;
        public virtual ConceptoCaja IdConceptoNavigation { get; set; } = null!;
        public virtual TipoFormaPago IdFormaPagoNavigation { get; set; } = null!;
        public virtual TipoLugar IdLugarNavigation { get; set; } = null!;
        public virtual TipoCaja IdTipoCajaNavigation { get; set; } = null!;
    }
}
