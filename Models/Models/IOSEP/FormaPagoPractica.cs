using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class FormaPagoPractica
    {
        public int FormaPagoPracticasID { get; set; }
        public int Encabezado_PresupuestoAprobadoID { get; set; }
        public DateTime? Fecha { get; set; }
        public short IdTipoFormaPago { get; set; }
        public int CantCuotas { get; set; }
        public decimal ImporteCuotas { get; set; }
        public decimal TotalCredito { get; set; }
        public decimal? TotalCreditoSinInt { get; set; }
        public decimal? ValorCuotaSinInt { get; set; }
        public int? AutorizacionesId { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool NotaCredito { get; set; }
    }
}
