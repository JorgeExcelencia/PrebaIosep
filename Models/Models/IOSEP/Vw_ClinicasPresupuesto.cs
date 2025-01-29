using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_ClinicasPresupuesto
    {
        public int IdPresupuesto { get; set; }
        public string Comprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdInternado { get; set; }
        public int? IdPresupuestoDetalle { get; set; }
        public int? IdNomenclador { get; set; }
        public string? NombrePractica { get; set; }
        public decimal? TotalCoseguro { get; set; }
        public decimal? TotalIosep { get; set; }
        public int? Cantidad { get; set; }
        public int IdAfiliado { get; set; }
        public string? CodigoPractica { get; set; }
        public decimal? Auditor_Porcentaje { get; set; }
        public string? Tipo { get; set; }
        public int IdPago { get; set; }
        public string Cuil { get; set; } = null!;
        public string? Nombre { get; set; }
    }
}
