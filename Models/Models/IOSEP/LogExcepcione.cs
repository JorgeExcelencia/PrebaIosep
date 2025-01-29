using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogExcepcione
    {
        public int IdExcepcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string IP_Origen { get; set; } = null!;
        public string Controlador { get; set; } = null!;
        public string Accion { get; set; } = null!;
        public string Parametros { get; set; } = null!;
        public string DetalleExcepcion { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}
