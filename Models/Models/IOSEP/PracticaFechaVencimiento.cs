using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PracticaFechaVencimiento
    {
        public int PracticaFechaVencimientoID { get; set; }
        public int AutorizacionID { get; set; }
        public DateTime FechaVencimientoOriginal { get; set; }
        public DateTime FechaVencimientoNueva { get; set; }
        public int MotivoCambioID { get; set; }
        public string? Observaciones { get; set; }
        public string UsuarioCambia { get; set; } = null!;
        public DateTime FechaCambia { get; set; }
    }
}
