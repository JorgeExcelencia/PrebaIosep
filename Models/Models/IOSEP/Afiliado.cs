using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Afiliado
    {
        public Afiliado()
        {
            AfiliadosCentroDeImagens = new HashSet<AfiliadosCentroDeImagen>();
            AutorizacionSepelios_Encabezados = new HashSet<AutorizacionSepelios_Encabezado>();
            Discapacitados = new HashSet<Discapacitado>();
            Encabezado_Autorizaciones = new HashSet<Encabezado_Autorizacione>();
            HCDigitalizada = new HashSet<HCDigitalizadum>();
            Planes_Afiliados = new HashSet<Planes_Afiliado>();
            SepelioSolicituds = new HashSet<SepelioSolicitud>();
            aportes = new HashSet<aporte>();
        }

        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public byte IdTipoDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string? ApellidoMaterno { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public int? IdNacionalidad { get; set; }
        public byte IdSexo { get; set; }
        public byte? IdSexoGenero { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public short? IdDelegacion { get; set; }
        /// <summary>
        /// Esta fecha indica hasta cuando el afiliado puede operar en el sistema.
        /// Si se encuentra vacio tiene uso de la obra social ilimitado.
        /// </summary>
        public DateTime? FechaVigencia { get; set; }
        public short IdMotivoBaja { get; set; }
        public DateTime? FechadeBaja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public short? IdCategoria { get; set; }
        public int? IdLugarPago { get; set; }
        public byte? IdSituacionLaboral { get; set; }
        public string A_Numero { get; set; }
        public int? DbfAfiliado { get; set; }
        public int? DbfGrupo { get; set; }
        public bool IosepSalud { get; set; }
        public string? LetArc { get; set; }
        public string? CodArc { get; set; }
        public bool Anulado { get; set; }
        public DateTime Fecha_CtaCTe { get; set; }
        public string? Fliar { get; set; }

        public virtual EstadoCivil? IdEstadoCivilNavigation { get; set; }
        public virtual Paise? IdNacionalidadNavigation { get; set; }
        public virtual Sexo Sexo { get; set; } = null!;
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
        public virtual TipoFamiliar IdTipoFamiliarNavigation { get; set; } = null!;
        public virtual ICollection<AfiliadosCentroDeImagen> AfiliadosCentroDeImagens { get; set; }
        public virtual ICollection<AutorizacionSepelios_Encabezado> AutorizacionSepelios_Encabezados { get; set; }
        public virtual ICollection<Discapacitado> Discapacitados { get; set; }
        public virtual ICollection<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; }
        public virtual ICollection<HCDigitalizadum> HCDigitalizada { get; set; }
        public virtual ICollection<Planes_Afiliado> Planes_Afiliados { get; set; }
        public virtual ICollection<SepelioSolicitud> SepelioSolicituds { get; set; }
        public virtual ICollection<aporte> aportes { get; set; }
    }
}
