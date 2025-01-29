using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_PrestadoresEspecialidad
    {
        public int idprestador { get; set; }
        public int IdPrestadorDDJJ { get; set; }
        public string? NombreCompleto { get; set; }
        public string Matricula { get; set; } = null!;
        public string CodigoColegio { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
        public string FechaDesdeEspecialidad { get; set; } = null!;
        public string FechaHastaEspecialidad { get; set; } = null!;
        public string MatriculaEspecialidad { get; set; } = null!;
        public int IdEspecialidad { get; set; }
    }
}
