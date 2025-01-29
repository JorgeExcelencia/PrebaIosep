using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Prestadore
    {
        public int idprestador { get; set; }
        public int IdPrestadorDDJJ { get; set; }
        public string Matricula { get; set; } = null!;
        public string CodigoColegio { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string? Apellido { get; set; }
        public string? Nombre { get; set; }
        public string? NombreCompleto { get; set; }
        public bool Anulado { get; set; }
    }
}
