using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MovimientosExpediente
    {
        public int MovimientoExpedienteID { get; set; }
        public int ExpedienteDigitalizadoID { get; set; }
        public string Informe { get; set; } = null!;
        public int SectorOrigenID { get; set; }
        public int SectorDestinoId { get; set; }
        public bool Rectificacion { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
