using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioAutorizacionDetalleOrden
    {
        public int SepelioAutorizacionDetalleOrdenID { get; set; }
        public int SepelioAutorizacionDetalleID { get; set; }
        public int? ProvinciaOrigenID { get; set; }
        public int? ProvinciaDestinoID { get; set; }
        public int? LocalidadOrigenID { get; set; }
        public int? LocalidadDestinoID { get; set; }
        public string NumeroOrden { get; set; } = null!;
        public string TipoOrden { get; set; } = null!;
        public string NumeroActa { get; set; } = null!;
        public DateTime FechaOrden { get; set; }
        public bool Estado { get; set; }

        public virtual Localidade? LocalidadDestino { get; set; }
        public virtual Localidade? LocalidadOrigen { get; set; }
        public virtual Provincia? ProvinciaDestino { get; set; }
        public virtual Provincia? ProvinciaOrigen { get; set; }
        public virtual SepelioAutorizacionDetalle SepelioAutorizacionDetalle { get; set; } = null!;
    }
}
