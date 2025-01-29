using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogWSConvenio
    {
        public int IdLog { get; set; }
        public string IP_Solicitud { get; set; } = null!;
        public string Parametros { get; set; } = null!;
        public string API { get; set; } = null!;
        public DateTime FechaHora { get; set; }
    }
}
