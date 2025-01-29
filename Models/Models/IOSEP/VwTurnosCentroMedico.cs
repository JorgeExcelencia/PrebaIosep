using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwTurnosCentroMedico
    {
        public int IdTurno { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int IdPrestador { get; set; }
        public string Matricula { get; set; } = null!;
        public string NombrePrestador { get; set; } = null!;
        public int? IdAfiliado { get; set; }
        public string? Cuil { get; set; }
        public string? NombreAfiliado { get; set; }
        public string? Hora_Llegada { get; set; }
        public string? Hora_Atendido { get; set; }
        public bool? Primera_Consulta { get; set; }
        public string? Telefono { get; set; }
        public string? Observacion { get; set; }
        public bool? NoDar { get; set; }
        public int? IdAfiliado_Anterior { get; set; }
        public bool? Suspendido { get; set; }
        public bool? Bloqueado { get; set; }
    }
}
