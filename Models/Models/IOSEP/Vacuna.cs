using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            Vacunas_Pacientes = new HashSet<Vacunas_Paciente>();
        }

        public int VacunaID { get; set; }
        public string Nombre { get; set; } = null!;
        public int EdadID { get; set; }
        public int GrupoId { get; set; }
        public string? Descripción { get; set; }
        public bool Anulado { get; set; }
        public bool Multidosis { get; set; }

        public virtual Vacunas_Edade Edad { get; set; } = null!;
        public virtual Vacunas_Grupo Grupo { get; set; } = null!;
        public virtual ICollection<Vacunas_Paciente> Vacunas_Pacientes { get; set; }
    }
}
