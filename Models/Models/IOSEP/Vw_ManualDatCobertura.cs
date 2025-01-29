using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_ManualDatCobertura
    {
        public DateTime Expr1 { get; set; }
        public int NroRegistro { get; set; }
        public string Troquel { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string Laboratorio { get; set; } = null!;
        public decimal Precio { get; set; }
        public string Fecha { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string? registro { get; set; }
        public string CodBarras { get; set; } = null!;
        public decimal? Cobertura_ambulatorio { get; set; }
        public decimal? Cobertura_Internado { get; set; }
        public string Baja { get; set; } = null!;
        public string Tamano { get; set; } = null!;
    }
}
