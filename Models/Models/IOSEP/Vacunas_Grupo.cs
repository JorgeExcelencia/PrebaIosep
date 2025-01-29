using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vacunas_Grupo
    {
        public Vacunas_Grupo()
        {
            Vacunas = new HashSet<Vacuna>();
        }

        public int GrupoId { get; set; }
        public string Nombre { get; set; } = null!;
        public int Orden { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}
