using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NEncabezado_Nomenclador
    {
        public int IdEncabezado_Nomenclador { get; set; }
        public int? IdTipo_Nomenclador { get; set; }
        public int? idprestador { get; set; }

        public virtual NTipo_Nomenclador IdEncabezado_NomencladorNavigation { get; set; } = null!;
        public virtual Prestadore? idprestadorNavigation { get; set; }
    }
}
