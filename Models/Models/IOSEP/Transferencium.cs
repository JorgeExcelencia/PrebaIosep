using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Transferencium
    {
        public int TransferenciaID { get; set; }
        public int ReintegrosEncabezadoID { get; set; }
        public int NroTransferencia { get; set; }
        public DateTime FechaTransferencia { get; set; }
        public decimal ImporteTransferencia { get; set; }
        public int BancoID { get; set; }
        public int EntidadBancariaID { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public string OperCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionAnula { get; set; }
        public int? IdCtaCte { get; set; }
        public string? ComprobantePago { get; set; }
        public string? Observaciones { get; set; }
        public int? NumeroCredito { get; set; }
        public int? IDEncabezadoVenta { get; set; }
        public int? AutorizacionesID { get; set; }
    }
}
