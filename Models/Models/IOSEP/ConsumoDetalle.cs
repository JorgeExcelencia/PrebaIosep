using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConsumoDetalle
    {
        public int IdConsumoDetalle { get; set; }
        public int IdConsumoEncabezado { get; set; }
        public int IdPractica { get; set; }
        public string CodigoPractica { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public short Cantidad { get; set; }
        public string Caras { get; set; } = null!;
        public int Pieza { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroPorcentaje { get; set; }
        public decimal Coseguro { get; set; }
        public string Estado { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ConsumoEncabezado IdConsumoEncabezadoNavigation { get; set; } = null!;
    }
}
