using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Municipio
    {
        public int IdMunicipio { get; set; }
        public string? CODCTA { get; set; }
        public string? DESCTA { get; set; }
        public string? DOMICI { get; set; }
        public DateTime? FECALT { get; set; }
        public string? ESTADO { get; set; }
        public DateTime? FECBAJ { get; set; }
        public decimal? CATEG { get; set; }
        public string? TIPCTA { get; set; }
        public string? IMPUTA { get; set; }
        public string? CUIT { get; set; }
        public decimal? AGRUPA { get; set; }
        public string? GENDEB { get; set; }
    }
}
