using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidades = new HashSet<Localidade>();
            SepelioAutorizacionDetalleOrdenProvinciaDestinos = new HashSet<SepelioAutorizacionDetalleOrden>();
            SepelioAutorizacionDetalleOrdenProvinciaOrigens = new HashSet<SepelioAutorizacionDetalleOrden>();
            SepelioSolicitudFacturacionDetalleDetalleProvinciaDestinos = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
            SepelioSolicitudFacturacionDetalleDetalleProvinciaOrigens = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
        }

        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Obra_Social { get; set; }
        public int? Anses { get; set; }
        public int? CodigoSisa { get; set; }
        public int? IdRegionSisa { get; set; }
        public decimal? Superficie { get; set; }
        public bool Anulado { get; set; }

        public virtual Paise IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<Localidade> Localidades { get; set; }
        public virtual ICollection<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdenProvinciaDestinos { get; set; }
        public virtual ICollection<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdenProvinciaOrigens { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalleProvinciaDestinos { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalleProvinciaOrigens { get; set; }
    }
}
