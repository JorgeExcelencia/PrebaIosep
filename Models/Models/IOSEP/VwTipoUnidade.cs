using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwTipoUnidade
    {
        public int IdNomTipoUnidad { get; set; }
        public short IdTipoUnidad { get; set; }
        public string Letra { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string HonGas { get; set; } = null!;
        public decimal Importe { get; set; }
        public string TipoCobertura { get; set; } = null!;
        public decimal Cobertura { get; set; }
        public DateTime FechaResolucion { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public DateTime? FinConvenio { get; set; }
        public string Resolucion { get; set; } = null!;
        public string LetUni { get; set; } = null!;
        public string Año { get; set; } = null!;
    }
}
