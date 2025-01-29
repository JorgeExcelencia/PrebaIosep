using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomenclaDbf
    {
        public int IdNomencla { get; set; }
        public string? CODIGO { get; set; }
        public string? P_CODIGO { get; set; }
        public string? NOMBRE { get; set; }
        public string? NIVEL { get; set; }
        public string? P_TIPO { get; set; }
        public decimal? G_TIPO { get; set; }
        public bool? NOMENCLADO { get; set; }
        public bool? INFORMA_P { get; set; }
        public bool? R_AUTOR { get; set; }
        public decimal? COLUMNA { get; set; }
        public decimal? HONORARIO { get; set; }
        public decimal? AYUDA_1 { get; set; }
        public decimal? AYUDA_2 { get; set; }
        public decimal? AYUDA_3 { get; set; }
        public decimal? AYUDA_4 { get; set; }
        public decimal? ANESTESIA { get; set; }
        public decimal? INSTRUMEN { get; set; }
        public decimal? GASTOS { get; set; }
        public string? SERIADA { get; set; }
        public bool? INF_ECO { get; set; }
        public decimal? MINEDA { get; set; }
        public decimal? MAXEDA { get; set; }
        public string? SEXO { get; set; }
        public decimal? AUDITOR { get; set; }
        public decimal? TOPMEN { get; set; }
        public decimal? TOPTRI { get; set; }
        public decimal? TOPSEM { get; set; }
        public decimal? TOPANU { get; set; }
        public bool? AUTO_STD { get; set; }
        public bool? AUTO_MOD { get; set; }
        public bool? AUTO_SUP { get; set; }
        public bool? AUTO_STDI { get; set; }
        public bool? AUTO_MODI { get; set; }
        public bool? AUTO_SUPI { get; set; }
        public decimal? DIASINT { get; set; }
        public string? O_CODIGO { get; set; }
    }
}
