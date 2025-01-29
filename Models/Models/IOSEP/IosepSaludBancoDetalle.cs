using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class IosepSaludBancoDetalle
    {
        public int IdIosepSaludBancoDetalle { get; set; }
        public int IdIosepSaludBanco { get; set; }
        public string succod { get; set; } = null!;
        public string sucursal { get; set; } = null!;
        public string moneda { get; set; } = null!;
        public string comprobante { get; set; } = null!;
        public string tipo_mov { get; set; } = null!;
        public decimal importe { get; set; }
        public DateTime fecha_proceso { get; set; }
        public string cuil { get; set; } = null!;
        public string usuario { get; set; } = null!;
        public string hora { get; set; } = null!;
        public string codbarra { get; set; } = null!;
        public string grupoterminal { get; set; } = null!;
        public string nrorendicion { get; set; } = null!;
        public DateTime fecha_cobro { get; set; }
        public int idCtaCteIosep { get; set; }
        public int? MotivoErrorID { get; set; }
    }
}
