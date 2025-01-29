using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomen_TipoUnidad
    {
        public int IdNomTipoUnidad { get; set; }
        public short IdTipoUnidad { get; set; }
        public decimal Importe { get; set; }
        public string TipoCobertura { get; set; } = null!;
        public decimal Cobertura { get; set; }
        public DateTime FechaResolucion { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public DateTime? FinConvenio { get; set; }
        public string Resolucion { get; set; } = null!;
        public string Letra { get; set; } = null!;
        public string Año { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
