using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwFamiliaresBono
    {
        public string? Nombre { get; set; }
        public string Cuil { get; set; } = null!;
        public int? Edad { get; set; }
        public string? Sexo { get; set; }
        public string CuilTitular { get; set; } = null!;
    }
}
