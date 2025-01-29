using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncTiposCampo
    {
        public IncTiposCampo()
        {
            IncCampos = new HashSet<IncCampo>();
        }

        public int TipoCampoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Objeto { get; set; } = null!;

        public virtual ICollection<IncCampo> IncCampos { get; set; }
    }
}
