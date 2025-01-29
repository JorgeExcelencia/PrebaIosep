using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reintegro_Debito
    {
        public int Reintegros_DebitosID { get; set; }
        public int ReintegroID { get; set; }
        public int ReintegroDetalleFacturaId { get; set; }
        public int ReintegroDetalleServId { get; set; }
        public int ReintegroDetalleMedId { get; set; }
        public int ReintegroDetallePractId { get; set; }
        public int TipoDebitoID { get; set; }
        public decimal CantidadDebitada { get; set; }
        public decimal ImporteDebitado { get; set; }
        public DateTime FechaDebito { get; set; }
        public string UsuarioDebita { get; set; } = null!;
    }
}
