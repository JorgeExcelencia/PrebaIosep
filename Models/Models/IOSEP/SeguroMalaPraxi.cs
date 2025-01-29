using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SeguroMalaPraxi
    {
        public SeguroMalaPraxi()
        {
            SeguroMalaPraxiPagos = new HashSet<SeguroMalaPraxiPago>();
        }

        public int SeguroMalaPraxiID { get; set; }
        public int EmpresaSeguroID { get; set; }
        public string NPoliza { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int PrestadorDDJJID { get; set; }
        public string? UbicacionRiesgo { get; set; }
        public bool? Franquicia { get; set; }
        public string? BaseCobertura { get; set; }
        public string? SPlan { get; set; }
        public decimal? SumaAsegurada { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }

        public virtual EmpresaSeguro EmpresaSeguro { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
        public virtual ICollection<SeguroMalaPraxiPago> SeguroMalaPraxiPagos { get; set; }
    }
}
