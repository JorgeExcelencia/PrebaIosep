using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reintegro_DetalleFactura
    {
        public Reintegro_DetalleFactura()
        {
            Reintegro_DetalleMedicacions = new HashSet<Reintegro_DetalleMedicacion>();
            Reintegro_DetallePracticas = new HashSet<Reintegro_DetallePractica>();
        }

        public int ReintegroDetalleFacturaID { get; set; }
        public int ReintegrosEncabezadoID { get; set; }
        public int? TipoInstitucionID { get; set; }
        public int? InstitucionID { get; set; }
        public int? PersonaID { get; set; }
        public string? Cuil { get; set; }
        public int? PrestadorID { get; set; }
        public int? ProveedorID { get; set; }
        public string? NombrePrestador { get; set; }
        public int? IdProvincia { get; set; }
        public bool? FueraProvincia { get; set; }
        public string? Periodo { get; set; }
        public DateTime? Fecha_Comprobante { get; set; }
        public int TipoComprobanteID { get; set; }
        public string? Numero_Comprobante { get; set; }
        public string? CAI { get; set; }
        public string? CAE { get; set; }
        public decimal? Importe { get; set; }
        public string? OperCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? MotivoAnula { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Rechazado { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public string? OperRechazo { get; set; }
        public string? MotivoRechazo { get; set; }
        public bool RechazaGerencia { get; set; }
        public DateTime? FechaRechazaGcia { get; set; }
        public string? OperRechazaGcia { get; set; }
        public string? MotivoRechazaGcia { get; set; }
        public int? OrdenPagoId { get; set; }
        public int? IdPais { get; set; }

        public virtual Reintegros_Encabezado ReintegrosEncabezado { get; set; } = null!;
        public virtual Tipo_Institucion? TipoInstitucion { get; set; }
        public virtual ICollection<Reintegro_DetalleMedicacion> Reintegro_DetalleMedicacions { get; set; }
        public virtual ICollection<Reintegro_DetallePractica> Reintegro_DetallePracticas { get; set; }
    }
}
