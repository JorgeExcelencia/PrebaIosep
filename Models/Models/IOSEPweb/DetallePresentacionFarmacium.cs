using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class DetallePresentacionFarmacium
    {
        public int PresentacionId { get; set; }
        public int EncabezadoId { get; set; }
        public int? NumReg { get; set; }
        public string? CiuInstitucion { get; set; }
        public string? PeriodoPresentacion { get; set; }
        public string? ConceptoPresentacion { get; set; }
        public string? CiuFarmacia { get; set; }
        public string? TipoOrden { get; set; }
        public string? SucursalAutorizacion { get; set; }
        public string? NumeroAutorizacion { get; set; }
        public decimal? ImporteCoseguroTotal { get; set; }
        public DateTime? FechaPrescripcion { get; set; }
        public DateTime? FechaExpendio { get; set; }
        public string? NumeroAfiliado { get; set; }
        public string? GradoParentesco { get; set; }
        public byte? EdadAfiliado { get; set; }
        public string? SexoAfiliado { get; set; }
        public string? CodigoDiagnostico { get; set; }
        public string? ProfesionalPrescriptor { get; set; }
        public string? CodigoBarras1 { get; set; }
        public string? CodigoTroquel1 { get; set; }
        public string? CodigoKairos1 { get; set; }
        public decimal? ImporteMedicamento1 { get; set; }
        public decimal? ACargoAfiliado1 { get; set; }
        public byte? CantidadExpendida1 { get; set; }
        public string? CodigoBarras2 { get; set; }
        public string? CodigoTroquel2 { get; set; }
        public string? CodigoKairos2 { get; set; }
        public decimal? ImporteMedicamento2 { get; set; }
        public decimal? ACargoAfiliado2 { get; set; }
        public byte? CantidadExpendida2 { get; set; }
        public string? TipoComprobante { get; set; }
        public string? NumeroSucursal { get; set; }
        public string? NumeroComprobante { get; set; }
        public string? TipoChequera { get; set; }
        public int IdTipoDebito { get; set; }
        public int IdTipoDebito1 { get; set; }
        public int IdTipoDebito2 { get; set; }
        public bool Anulado { get; set; }
        public decimal? Cobertura1 { get; set; }
        public decimal? Cobertura2 { get; set; }
        public decimal? Debitado { get; set; }
        public decimal? Debitado1 { get; set; }
        public decimal? Debitado2 { get; set; }
        public bool Chequeado { get; set; }
    }
}
