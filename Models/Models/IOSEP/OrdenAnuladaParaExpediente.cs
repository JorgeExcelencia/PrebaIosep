using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenAnuladaParaExpediente
    {
        public int OrdenAnuladaId { get; set; }
        public string NumeroBono { get; set; } = null!;
        public int MotivoAnulaId { get; set; }
        public string UsuarioAnula { get; set; } = null!;
        public DateTime FechaAnula { get; set; }
    }
}
