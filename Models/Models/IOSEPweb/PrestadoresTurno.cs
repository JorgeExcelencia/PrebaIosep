using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PrestadoresTurno
    {
        public int PrestadorId { get; set; }
        public string Matricula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int EspecialidadId { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool Anulado { get; set; }

        public virtual Especialidade Especialidad { get; set; } = null!;
    }
}
