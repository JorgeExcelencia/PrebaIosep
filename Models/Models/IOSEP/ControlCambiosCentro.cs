using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ControlCambiosCentro
    {
        public int ControlCambiosCentroID { get; set; }
        public string UsuarioCambio { get; set; } = null!;
        public DateTime FechaCambio { get; set; }
        public int MotivoCambio { get; set; }
        public string? Observaciones { get; set; }
        public bool Presupuesto { get; set; }
        public int Encabezado { get; set; }
        public bool Anulado { get; set; }
        public int? IdCentroAnterior { get; set; }
    }
}
