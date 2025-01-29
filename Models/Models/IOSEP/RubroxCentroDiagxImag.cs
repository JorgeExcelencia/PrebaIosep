using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RubroxCentroDiagxImag
    {
        public int RubroxCentroDiagxImagID { get; set; }
        public int GrupoPrestadorID { get; set; }
        public decimal PorcentajeAfiliados { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? UsuarioCrea { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
    }
}
