using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class GrupoMedicamento
    {
        public int IdGrupoMedicamentos { get; set; }
        public string NombreGrupo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
