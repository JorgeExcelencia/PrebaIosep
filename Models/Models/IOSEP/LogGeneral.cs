using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogGeneral
    {
        public int LogGeneralID { get; set; }
        public string Tabla { get; set; } = null!;
        public int ID { get; set; }
        public string Accion { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
    }
}
