using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ContencionFliarDetalle
    {
        public int DetalleContencionFliarID { get; set; }
        public int EncabezadoContencionID { get; set; }
        public int PracticaID { get; set; }
        public decimal Coseguro { get; set; }
        public decimal PrecioPractica { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}
