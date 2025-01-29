using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reintegro_DetalleServicio
    {
        public int ReintegroDetalleServiciosID { get; set; }
        public int ReintegroDetalleFacturaID { get; set; }
        public int? PersonaID { get; set; }
        public int? ProveedorID { get; set; }
        public int NroRegistro { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ImporteUnitario { get; set; }
        public decimal CantidadReintegrar { get; set; }
        public decimal PrecioIosep { get; set; }
        public decimal PorcentajeReconocido { get; set; }
        public decimal ImporteACargoIosep { get; set; }
        public decimal ImporteACargoAfiliado { get; set; }
        public string? UsuarioAudita { get; set; }
        public DateTime? FechaAudita { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Auditado { get; set; }
        public string? MotivoAnulado { get; set; }
        public bool Anulado { get; set; }
        public bool Rechazado { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public string? OperRechazo { get; set; }
        public string? MotivoRechazo { get; set; }
        public bool AuditaGerencia { get; set; }
        public bool RechazaGerencia { get; set; }
        public DateTime? FechaRechazaGcia { get; set; }
        public string? OperRechazaGcia { get; set; }
        public string? MotivoRechazaGcia { get; set; }
        public string? OperAuditaGcia { get; set; }
        public DateTime? FechaAuditaGcia { get; set; }
        public bool Auditable { get; set; }
        public string? OperMarca { get; set; }
        public DateTime? FechaMarca { get; set; }
        public string? Descripcion { get; set; }
        public int IdFactura { get; set; }
    }
}
