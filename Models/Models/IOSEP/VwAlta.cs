using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAlta
    {
        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdTitular { get; set; }
        public string Titular { get; set; } = null!;
        public int IdClinica { get; set; }
        public string? Codigo { get; set; }
        public string? Diagnostico { get; set; }
        public short? IdTipoInternacion { get; set; }
        public string? matricula { get; set; }
        public string? NombrePrestador { get; set; }
        public short IdEstado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public bool Anulada { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public string? ComplejidadNivel { get; set; }
        public bool? Anestesia { get; set; }
        public int? IdClinica_Deriva { get; set; }
        public short? IdMotivoAlta { get; set; }
        public int? IdDiagnosticoAlta { get; set; }
        public int? IdPrestadorAlta { get; set; }
        public string? Obs_AuditaAlta { get; set; }
        public string? NumeroAlta { get; set; }
        public string? RespAuditorAlta { get; set; }
        public string? AuditaAlta { get; set; }
        public DateTime? AutorizadoAlta { get; set; }
        public short? IdEstado_Anterior { get; set; }
    }
}
