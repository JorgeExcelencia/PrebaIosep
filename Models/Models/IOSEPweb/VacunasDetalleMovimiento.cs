using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasDetalleMovimiento
    {
        public int DetalleMovimientoId { get; set; }
        public int MovimientoId { get; set; }
        public byte Dosis { get; set; }
        public string Vacuna { get; set; } = null!;
        public DateTime FechaAplica { get; set; }
        public int? DelegacionId { get; set; }
        public string? Delegacion { get; set; }
        public string? Observacion { get; set; }
        public int? Meses { get; set; }
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual VacunasMovimiento Movimiento { get; set; } = null!;
    }
}
