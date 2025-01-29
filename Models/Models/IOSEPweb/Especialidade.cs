using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            PrestadoresTurnos = new HashSet<PrestadoresTurno>();
            Servicios = new HashSet<Servicio>();
        }

        public int EspecialidadId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Grilla { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadoresTurno> PrestadoresTurnos { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
