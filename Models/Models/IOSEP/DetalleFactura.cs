using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DetalleFactura
    {
        public int DetalleFacturaID { get; set; }
        public int ReintegroDetalleFacturaID { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
    }
}
