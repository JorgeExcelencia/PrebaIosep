using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConstanciasAfiliado
    {
        public int ConstanciasAfiliadoID { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public int DiasValidos { get; set; }
        public int MotivoConstanciaID { get; set; }
        public int? IdInternado { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? OtrosPadrones { get; set; }
        public bool? IosepSalud { get; set; }
        public string? IP { get; set; }
        public string? CodigoVerificacion { get; set; }
    }
}
