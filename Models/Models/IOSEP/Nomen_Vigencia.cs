using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomen_Vigencia
    {
        public int IdNomen_Vigencia { get; set; }
        /// <summary>
        /// Tipo 1: Valores
        /// Tipo 2: Unidades
        /// </summary>
        public byte IdTipoModalidad { get; set; }
        public int IdTipo { get; set; }
        public int IdNomenclador { get; set; }
        public short IdTipoNom { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public DateTime? FinConvenio { get; set; }
        public string Resolucion { get; set; } = null!;
        public string Letra { get; set; } = null!;
        public string Año { get; set; } = null!;
    }
}
