using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CtaCte
    {
        public int IdCtaCte { get; set; }
        public DateTime Fecha { get; set; }
        public int IdAfiliado { get; set; }
        public int IdCajaTipoOrigen { get; set; }
        public string Comprobante { get; set; } = null!;
        public byte Cantidad_Cuotas { get; set; }
        public decimal Total { get; set; }
        public string? CodigoBarra { get; set; }
        public int? IdTipo_Movimiento { get; set; }
        public byte? Boletas { get; set; }
        public string? Detalle { get; set; }
        public int? IdEmpresa { get; set; }
        public bool Anulado { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? AnulaOperador { get; set; }
        public DateTime? AnulaFecha { get; set; }
        public string? Observaciones { get; set; }
        public int? MotivoAnulacionId { get; set; }
        public string? ObsAnulacion { get; set; }
        public string? Periodo { get; set; }
        public int? IdDetalle { get; set; }
    }
}
