using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisNomenclador
    {
        public int ProtesisNomencladorID { get; set; }
        public int ProtesisGenericaID { get; set; }
        public int ProtesisNombreComercialID { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? Presentacion { get; set; }
        public int? ProtesisOrigenID { get; set; }
        public int? ProtesisMarcaID { get; set; }
        public int? ProtesisRubroID { get; set; }
        public string? Indicaciones { get; set; }
        public string? Observaciones { get; set; }
        public decimal? PrecioReferencia { get; set; }
        public int? TipoMonedaID { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObsAnula { get; set; }
    }
}
