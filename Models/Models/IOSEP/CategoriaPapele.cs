using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CategoriaPapele
    {
        public int IdCategoriaPapeles { get; set; }
        public int IdCategoria { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public int IdPapel { get; set; }
        public int IdCosspra { get; set; }
        public bool Anulado { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
        public virtual Papele IdPapelNavigation { get; set; } = null!;
    }
}
