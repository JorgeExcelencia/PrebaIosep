using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VW_VISTA_PROVISORIA_NOMENCLADOR_GENERAL_VALORE
    {
        public int idnomenclador { get; set; }
        public string codigo { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public int IdTipoPractica { get; set; }
        public int IdModalidad { get; set; }
        public int IdTipoCategoria { get; set; }
        public string? nivel { get; set; }
        public string? p_tipo { get; set; }
        public byte? g_tipo { get; set; }
        public int IdNomen_Valores { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime FechaResolucion { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public DateTime FechaFinConvenio { get; set; }
        public string Resolucion { get; set; } = null!;
        public string Letra { get; set; } = null!;
        public string Año { get; set; } = null!;
        public decimal? Especialista { get; set; }
        public decimal? Ayudante_1 { get; set; }
        public decimal? Ayudante_2 { get; set; }
        public decimal? Ayudante_4 { get; set; }
        public decimal? Anestesista { get; set; }
        public decimal? Instrumentadora { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? Total { get; set; }
        public decimal? Ayudante_3 { get; set; }
    }
}
