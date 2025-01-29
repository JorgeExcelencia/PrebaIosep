using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReintegrosServicioIosep
    {
        public int ReintegroServicioIosepId { get; set; }
        public string CodServicio { get; set; } = null!;
        public string DetalleServicio { get; set; } = null!;
        public bool Servicio { get; set; }
        public bool Descuento { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? OperAnul { get; set; }
        public DateTime? FechaAnul { get; set; }
        public bool Anulado { get; set; }
    }
}
