using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Log
    {
        public long IdLog { get; set; }
        public string Tabla { get; set; } = null!;
        public byte? IdEstadoOperacion { get; set; }
        public string? Operador { get; set; }
        public DateTime? Fecha { get; set; }
        public long? IdReferencia { get; set; }
        public string? Detalle { get; set; }
    }
}
