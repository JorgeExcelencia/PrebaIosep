using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInterOtraClinica
    {
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int idinternado { get; set; }
        public int idclinica { get; set; }
        public string NombreClinica { get; set; } = null!;
        public short idestado { get; set; }
        public bool hijo { get; set; }
        public DateTime DiaHora { get; set; }
        public bool EsAlta { get; set; }
    }
}
