using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ordene
    {
        public int IdOrden { get; set; }
        public int? IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public string TipoOrden { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public int IdDelegacion { get; set; }
        public int? IdPrescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int? IdDiagnostico { get; set; }
        public int? IdNomenclador { get; set; }
        public byte Cantidad { get; set; }
        public DateTime Fecha_Prescripcion { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Vence { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
        public bool SobreTope { get; set; }
        public string? TipoReconoce { get; set; }
        public string? Observacion { get; set; }
        public string? Motivo { get; set; }
        public byte TipoAutorizacion { get; set; }
        public string? Operador { get; set; }
        public bool Anulada { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? Modifica { get; set; }
        public byte? IosepSalud { get; set; }
        public byte IdLugar { get; set; }
        public int? IdInstitucion { get; set; }
    }
}
