using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadoresMatriculado
    {
        public int IdPrestador { get; set; }
        public string Matricula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
        public DateTime? Obtencion { get; set; }
        public DateTime? Caducidad { get; set; }
        public string? Revalida { get; set; }
        public string? Categoria { get; set; }
        public int? Antiguedad { get; set; }
    }
}
