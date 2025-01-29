using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAfiliadosMaraton
    {
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public DateTime FechadeNacimiento { get; set; }
        public string? Domicilio { get; set; }
        public int? Edad { get; set; }
        public int Pre { get; set; }
        public int? Numero { get; set; }
        public string? Categoria { get; set; }
    }
}
