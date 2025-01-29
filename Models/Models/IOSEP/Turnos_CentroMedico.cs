using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Turnos_CentroMedico
    {
        public int idturno { get; set; }
        public DateTime fecha_hora { get; set; }
        public int idprestador { get; set; }
        public int? idafiliado { get; set; }
        public string? hora_llegada { get; set; }
        public string? hora_atendido { get; set; }
        public bool? primera_consulta { get; set; }
        public string? telefono { get; set; }
        public string? observacion { get; set; }
        public bool? nodar { get; set; }
        public string? operador_dio { get; set; }
        public string? Operador_Atendio { get; set; }
        public string? operador_anulo { get; set; }
        public int? idafiliado_anterior { get; set; }
        public bool? suspendido { get; set; }
        public bool? bloqueado { get; set; }
    }
}
