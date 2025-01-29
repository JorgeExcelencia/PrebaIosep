using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternado
    {
        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdTitular { get; set; }
        public string Titular { get; set; } = null!;
        public int IdClinica { get; set; }
        public int IdDiagnostico { get; set; }
        public string? Codigo { get; set; }
        public string? Diagnostico { get; set; }
        public short? IdTipoInternacion { get; set; }
        public int? IdPrestador { get; set; }
        public string? matricula { get; set; }
        public string? NombrePrestador { get; set; }
        public DateTime Fecha_Internacion { get; set; }
        public string? Habitacion { get; set; }
        public string? Cama { get; set; }
        public byte Edad { get; set; }
        public bool Hijo { get; set; }
        public string? Tratamiento { get; set; }
        public string? Obs_Auditor { get; set; }
        public string? RespAuditor { get; set; }
        public short IdEstado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public bool Anulada { get; set; }
        public bool Art { get; set; }
        public bool AccidenteTansito { get; set; }
        public short? IdEstado_Anterior { get; set; }
    }
}
