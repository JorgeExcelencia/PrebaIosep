using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EquiposPractica
    {
        public EquiposPractica()
        {
            PrestadorDDJJEquiposPracticas = new HashSet<PrestadorDDJJEquiposPractica>();
        }

        public int EquiposPracticasID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJEquiposPractica> PrestadorDDJJEquiposPracticas { get; set; }
    }
}
