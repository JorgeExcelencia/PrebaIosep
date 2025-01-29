using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEncabezadoPresentacion
    {
        public FarEncabezadoPresentacion()
        {
            FarDetallePresentacions = new HashSet<FarDetallePresentacion>();
        }

        public int IdEncabezadoPresentacion { get; set; }
        public int EncabezadoId { get; set; }
        public int? NumReg { get; set; }
        public string? CiuInstitucion { get; set; }
        public string? PeriodoPresentacion { get; set; }
        public string? ConceptoPresentacion { get; set; }
        public string? CiuFarmacia { get; set; }
        public string? TipoOrden { get; set; }
        public string? SucursalAutorizacion { get; set; }
        public string? NumeroAutorizacion { get; set; }
        public DateTime? FechaPrescripcion { get; set; }
        public DateTime? FechaExpendio { get; set; }
        public string? NumeroAfiliado { get; set; }
        public string? GradoParentesco { get; set; }
        public byte? EdadAfiliado { get; set; }
        public string? SexoAfiliado { get; set; }
        public string? CodigoDiagnostico { get; set; }
        public string? ProfesionalPrescriptor { get; set; }
        public decimal? ImporteCoseguroTotal { get; set; }
        public decimal? ACargoAfiliado { get; set; }
        public decimal? ACargoIosep { get; set; }
        public decimal? Debitado { get; set; }
        public string? TipoComprobante { get; set; }
        public string? NumeroSucursal { get; set; }
        public string? NumeroComprobante { get; set; }
        public string? TipoChequera { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public bool Anulado { get; set; }
        public bool Chequeado { get; set; }
        public string? Nombre { get; set; }
        public int? Idafiliado { get; set; }
        public DateTime? Modificado { get; set; }
        public string? Usuario { get; set; }

        public virtual EncabezadoPresentacionFarmacium Encabezado { get; set; } = null!;
        public virtual ICollection<FarDetallePresentacion> FarDetallePresentacions { get; set; }
    }
}
