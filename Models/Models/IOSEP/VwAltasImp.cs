using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAltasImp
    {
        public int IdInternado { get; set; }
        public string Codigo { get; set; } = null!;
        public string Diagnostico { get; set; } = null!;
        public string matricula { get; set; } = null!;
        public string NombrePrestador { get; set; } = null!;
        public short IdEstado { get; set; }
        public bool Anulada { get; set; }
        public bool? Anestesia { get; set; }
        public string? ComplejidadNivel { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public short? IdMotivoAlta { get; set; }
        public string TipoAlta { get; set; } = null!;
        public string? NumeroAlta { get; set; }
        public DateTime? AutorizadoAlta { get; set; }
        public string? AuditaAlta { get; set; }
    }
}
