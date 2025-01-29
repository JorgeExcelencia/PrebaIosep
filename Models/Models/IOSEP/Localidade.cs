using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Localidade
    {
        public Localidade()
        {
            Domicilios = new HashSet<Domicilio>();
            DomiciliosDDJJs = new HashSet<DomiciliosDDJJ>();
            SepelioAutorizacionDetalleOrdenLocalidadDestinos = new HashSet<SepelioAutorizacionDetalleOrden>();
            SepelioAutorizacionDetalleOrdenLocalidadOrigens = new HashSet<SepelioAutorizacionDetalleOrden>();
            SepelioSolicitudFacturacionDetalleDetalleLocalidadDestinos = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
            SepelioSolicitudFacturacionDetalleDetalleLocalidadOrigens = new HashSet<SepelioSolicitudFacturacionDetalleDetalle>();
        }

        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public string? Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public byte? Estado { get; set; }
        public string CodigoPostal { get; set; } = null!;
        public int? IdDelegacion { get; set; }
        public string? Departamento { get; set; }
        public bool Anulado { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; } = null!;
        public virtual ICollection<Domicilio> Domicilios { get; set; }
        public virtual ICollection<DomiciliosDDJJ> DomiciliosDDJJs { get; set; }
        public virtual ICollection<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdenLocalidadDestinos { get; set; }
        public virtual ICollection<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdenLocalidadOrigens { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalleLocalidadDestinos { get; set; }
        public virtual ICollection<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalleLocalidadOrigens { get; set; }
    }
}
