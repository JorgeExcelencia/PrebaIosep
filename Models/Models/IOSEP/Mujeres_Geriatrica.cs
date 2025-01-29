using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Mujeres_Geriatrica
    {
        public int idMujeres { get; set; }
        public int idafiliado { get; set; }
        public string A_numero { get; set; } = null!;
        public string Familiar { get; set; } = null!;
        public string cuil { get; set; } = null!;
        public bool anulado { get; set; }
    }
}
