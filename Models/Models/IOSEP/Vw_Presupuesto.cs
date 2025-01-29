using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Presupuesto
    {
        public string Comprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdInternado { get; set; }
        public string Operador { get; set; } = null!;
        public int FormaPagoCodigo { get; set; }
        public string? FormaPagoDetalle { get; set; }
        public int? IdNomenclador { get; set; }
        public bool? Anulado { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public int IdPresupuesto { get; set; }
        public int IdPago { get; set; }
        public string? Nombre { get; set; }
        public string? CodigoPractica { get; set; }
        public string? NombrePractica { get; set; }
        public decimal? TotalCoseguro { get; set; }
        public decimal? TotalIosep { get; set; }
        public int? Cantidad { get; set; }
        public string? Tipo { get; set; }
        public decimal? Auditor_Porcentaje { get; set; }
        public int? IdAutoriza { get; set; }
        public int? TipoIdAutoriza { get; set; }
        public DateTime? Fecha_Prescripcion { get; set; }
        public decimal? SubTotal { get; set; }
    }
}
