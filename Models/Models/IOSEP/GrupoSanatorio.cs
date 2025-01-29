using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoSanatorio
    {
        public GrupoSanatorio()
        {
            GrupoDetalleSanatorios = new HashSet<GrupoDetalleSanatorio>();
        }

        public int IdGrupoSanatorios { get; set; }
        public string NombreGrupo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<GrupoDetalleSanatorio> GrupoDetalleSanatorios { get; set; }
    }
}
