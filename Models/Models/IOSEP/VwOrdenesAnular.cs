using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwOrdenesAnular
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public int Caja { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Practica { get; set; }
        public string? DetallePractica { get; set; }
        public string TipoOrden { get; set; } = null!;
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
        public byte? IosepSalud { get; set; }
        public byte Cantidad { get; set; }
        public string Numero { get; set; } = null!;
        public bool Anulada { get; set; }
        public string? Operador { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? Modifica { get; set; }
        public string? Motivo { get; set; }
    }
}
