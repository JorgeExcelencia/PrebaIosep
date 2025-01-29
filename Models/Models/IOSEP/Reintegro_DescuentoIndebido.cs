using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reintegro_DescuentoIndebido
    {
        public int ReintegroDescuentoIndebidoID { get; set; }
        public int ReintegroDetalleFacturaID { get; set; }
        public int IdAfiliado { get; set; }
        public string MesAnio { get; set; } = null!;
        public decimal HaberConAporte { get; set; }
        public int Porcentaje { get; set; }
        public decimal TotalDescuento { get; set; }
        public string? Codigo { get; set; }
        public string? UsuarioAudita { get; set; }
        public DateTime? FechaAudita { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnulado { get; set; }
        public bool Auditado { get; set; }
        public bool Anulado { get; set; }
        public bool Rechazado { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public string? OperRechazo { get; set; }
        public string? MotivoRechazo { get; set; }
        public int? IdFactura { get; set; }
        public int CantMenoresDescuento { get; set; }
        public int CantMenoresReintegrar { get; set; }
    }
}
