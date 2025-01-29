using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MedicamentosRedFarmacium
    {
        public int MedicamentoRedFarmaciaID { get; set; }
        public int NroRegistro { get; set; }
        public int NuevaDro { get; set; }
        public int MultiDro { get; set; }
        public string Presentacion { get; set; } = null!;
        public string? Gtin { get; set; }
        public string? CodBarras { get; set; }
        public string? Troquel { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string? Observacion { get; set; }
        public int? ProvistoPorID { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionesAnula { get; set; }
        public DateTime? VencimientoAnterior { get; set; }
        public int? ProvistoAnt { get; set; }
        public decimal? UnidadesInternacDiarias { get; set; }
        public decimal? Precio { get; set; }
    }
}
