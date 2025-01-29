using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarDetallePresentacion
    {
        public int IdDetallePresentacion { get; set; }
        public int IdEncabezadoPresentacion { get; set; }
        public int EncabezadoId { get; set; }
        public int? NumReg { get; set; }
        public string? CodigoBarras { get; set; }
        public string? CodigoTroquel { get; set; }
        public string? CodigoKairos { get; set; }
        public decimal? ImporteMedicamento { get; set; }
        public decimal? Cobertura { get; set; }
        public decimal? ACargoAfiliado { get; set; }
        public decimal? ACargoIosep { get; set; }
        public byte? CantidadExpendida { get; set; }
        public decimal? Debitado { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public bool Anulado { get; set; }
        public string? NombreMedicamento { get; set; }

        public virtual FarEncabezadoPresentacion IdEncabezadoPresentacionNavigation { get; set; } = null!;
    }
}
