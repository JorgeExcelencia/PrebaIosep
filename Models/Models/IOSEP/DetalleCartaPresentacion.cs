using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DetalleCartaPresentacion
    {
        public int DetalleCartaPresentacionID { get; set; }
        public int CartaPresentacionID { get; set; }
        public DateTime FechaRenovacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int ProvinciaID { get; set; }
        public int DelegacionID { get; set; }
        public int ConvenioReciprocidadID { get; set; }
        public int? CentroMedico { get; set; }
        public int? TransporteID { get; set; }
        public decimal? CoberturaTransporte { get; set; }
        public bool Acompaniante { get; set; }
        public bool UnAcompaniante { get; set; }
        public int CantidadAcomp { get; set; }
        public int? idprestador { get; set; }
        public string? Observaciones { get; set; }
        public string UsuarioRenueva { get; set; } = null!;
        public DateTime FechaRenueva { get; set; }
        public int ProvinciaEmite { get; set; }
        public DateTime FechaEmision { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}
