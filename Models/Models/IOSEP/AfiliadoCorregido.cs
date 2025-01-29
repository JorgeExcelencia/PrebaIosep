using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadoCorregido
    {
        public int AfiliadoCorregidoID { get; set; }
        public string Usuario { get; set; } = null!;
        public string NroAfiliado { get; set; } = null!;
        public string CuilNuevo { get; set; } = null!;
        public string CuilViejo { get; set; } = null!;
        public DateTime FechaCoreccion { get; set; }
    }
}
