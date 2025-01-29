using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrescripcionRenglon
    {
        public int IdPrescripcionRenglon { get; set; }
        public int IdPrescripcionElectronica { get; set; }
        public string TipoPrescripcion { get; set; } = null!;
        public string? GenericoDrogas { get; set; }
        public string? GenericoPresentacion { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ProductoCodigoBarras { get; set; }
        public string? ProductoTroquel { get; set; }
        public string? ProductoCodigoAlfaBeta { get; set; }
        public string? CantidadEnvases { get; set; }
        public string? Diagnostico { get; set; }
        public string? CIE10 { get; set; }
        public string? Indicaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
