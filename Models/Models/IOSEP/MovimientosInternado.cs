using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MovimientosInternado
    {
        public int MovInternadoID { get; set; }
        public int IdInternado { get; set; }
        public short IdEstado { get; set; }
        public short? TipoAltaID { get; set; }
        public DateTime Fecha { get; set; }
        public int IDPrestador { get; set; }
        public int IDDiagnostico { get; set; }
        public int TipoInternacionID { get; set; }
        public int? ClinicaDerivaID { get; set; }
        public int? SectorID { get; set; }
        public string? Pabellon { get; set; }
        public string? Cama { get; set; }
        public string? Denominacion { get; set; }
        public string? Observacion { get; set; }
        public string? Auditor { get; set; }
        public bool Activo { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? OpCreaFecha { get; set; }
        public string? IP { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public bool Anulado { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }

        public virtual Estados_Internacion IdEstadoNavigation { get; set; } = null!;
        public virtual Internado IdInternadoNavigation { get; set; } = null!;
        public virtual InternadosSector? Sector { get; set; }
        public virtual TipoAltum? TipoAlta { get; set; }
        public virtual TipoInternacion TipoInternacion { get; set; } = null!;
    }
}
