using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwPesca
    {
        public string a_numero { get; set; } = null!;
        public string familiar { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public DateTime? fecha { get; set; }
        public DateTime? Carnet { get; set; }
        public DateTime? Turno1 { get; set; }
        public DateTime? Turno2 { get; set; }
        public int IdAfiliado { get; set; }
        public string cuil { get; set; } = null!;
    }
}
