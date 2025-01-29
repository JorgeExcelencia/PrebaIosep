using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAutoMapa
    {
        public long Id { get; set; }
        public int IdInternado { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha_Internacion { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Auditado { get; set; }
        public string? AuditorInternacion { get; set; }
        public DateTime? AuditadoAlta { get; set; }
        public string? AuditorAlta { get; set; }
        public string? MapaInternacion { get; set; }
        public string? MapaAlta { get; set; }
        public string? Estado { get; set; }
        public DateTime? Cargado { get; set; }
        public string? OperadorCarga { get; set; }
        public string? MapaCarga { get; set; }
        public DateTime? CargadoAlta { get; set; }
        public string? OperadorAlta { get; set; }
        public string? MapaCargaAlta { get; set; }
    }
}
