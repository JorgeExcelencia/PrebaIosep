using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class OlimpiadasDetalleMovimiento
    {
        public int DetalleMovimientoId { get; set; }
        public int MovimientoId { get; set; }
        public int DisciplinaId { get; set; }
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual OlimpiadasDisciplina Disciplina { get; set; } = null!;
        public virtual OlimpiadasMovimiento Movimiento { get; set; } = null!;
    }
}
