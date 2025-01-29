using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class IosepSaludHistorialCuota
    {
        public int IdIosepSaludHistorialCuotas { get; set; }
        public string Resolucion { get; set; } = null!;
        public string? ReferenciaResolucion { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public decimal Titular1 { get; set; }
        public decimal Esposa1 { get; set; }
        public decimal Hijo1 { get; set; }
        public decimal Titular2 { get; set; }
        public decimal Esposa2 { get; set; }
        public decimal Hijo2 { get; set; }
        public decimal Titular3 { get; set; }
        public decimal Esposa3 { get; set; }
        public decimal Hijo3 { get; set; }
        public decimal Titular4 { get; set; }
        public decimal Esposa4 { get; set; }
        public decimal Hijo4 { get; set; }
        public decimal Titular5 { get; set; }
        public decimal Esposa5 { get; set; }
        public decimal Hijo5 { get; set; }
        public decimal Titular6 { get; set; }
        public decimal Titular7 { get; set; }
        public decimal Adicional7 { get; set; }
        public decimal ImporteConvenio { get; set; }
        public DateTime Cargada { get; set; }
        public string OperadorCarga { get; set; } = null!;
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulada { get; set; }
        public DateTime? FechaHastaAnterior { get; set; }
    }
}
