using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadosAdicional
    {
        public int AfiliadoAdicionalID { get; set; }
        public int IdAfiliado { get; set; }
        public int TipoVencimientoID { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int? IdTipoIngreso { get; set; }
        public int IdCosspra { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? DescripcionMotivoBaja { get; set; }
        public string? Observaciones { get; set; }
    }
}
