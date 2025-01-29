using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioSolicitudFacturacionDetalleDetalle
    {
        public int SepelioSolicitudFacturacionDetalleDetalleID { get; set; }
        public int SepelioSolicitudFacturacionDetalleID { get; set; }
        public int SepelioServicioDetalleID { get; set; }
        public int? ProvinciaOrigenID { get; set; }
        public int? ProvinciaDestinoID { get; set; }
        public int? LocalidadOrigenID { get; set; }
        public int? LocalidadDestinoID { get; set; }
        public decimal Importe { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }
        public bool Anulado { get; set; }

        public virtual Localidade? LocalidadDestino { get; set; }
        public virtual Localidade? LocalidadOrigen { get; set; }
        public virtual Provincia? ProvinciaDestino { get; set; }
        public virtual Provincia? ProvinciaOrigen { get; set; }
        public virtual SepelioServicioDetalle SepelioServicioDetalle { get; set; } = null!;
        public virtual SepelioSolicitudFacturacionDetalle SepelioSolicitudFacturacionDetalle { get; set; } = null!;
    }
}
