using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadoresMatriculados_
    {
        public int IdPrestador { get; set; }
        public string? Matricula { get; set; }
        public string? Nombre { get; set; }
        public string? Especialidad { get; set; }
        public DateTime? Obtención { get; set; }
        public DateTime? Caducidad { get; set; }
        public string? Revalida { get; set; }
    }
}
