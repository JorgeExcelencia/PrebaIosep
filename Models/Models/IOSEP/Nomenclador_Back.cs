using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomenclador_Back
    {
        public int IdNomenclador { get; set; }
        public int? IdTipo_Nomencladores { get; set; }
        public int? IdNivel_Nomenclador { get; set; }
        public string? nivel { get; set; }
        public int? IdTipo_Practica { get; set; }
        public string? p_tipo { get; set; }
        public int? IdTipo_Gasto { get; set; }
        public byte? g_tipo { get; set; }
        public bool? nomenclado { get; set; }
        public bool? informa_p { get; set; }
        public bool? r_autor { get; set; }
        public byte? columna { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Ayudante_1 { get; set; }
        public decimal? Ayudante_2 { get; set; }
        public decimal? Ayudante_3 { get; set; }
        public decimal? Ayudante_4 { get; set; }
        public decimal? Anestesista { get; set; }
        public decimal? Instrumentista { get; set; }
        public decimal? Gastos { get; set; }
        public string? Seriada { get; set; }
        public bool? Informe_Ecografia { get; set; }
        public short? Edad_Minima { get; set; }
        public short? Edad_Maxima { get; set; }
        public string? Sexo { get; set; }
        public int? Sexo_Legal { get; set; }
        public byte? Autoriza_Auditor { get; set; }
        public short? Tope_Mensual { get; set; }
        public short? Tope_Trimestral { get; set; }
        public short? Tope_Semanal { get; set; }
        public short? Tope_Anual { get; set; }
        public string? Tope_Semestral { get; set; }
        public bool? auto_std { get; set; }
        public bool? auto_mod { get; set; }
        public bool? auto_sup { get; set; }
        public bool? auto_stdi { get; set; }
        public bool? auto_modi { get; set; }
        public bool? auto_supi { get; set; }
        public short? dias_internacion { get; set; }
        public string? Factura_Codigo { get; set; }
        public bool anulado { get; set; }
    }
}
