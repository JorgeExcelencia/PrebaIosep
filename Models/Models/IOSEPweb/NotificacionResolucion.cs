using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class NotificacionResolucion
    {
        public int NotificacionResolucionId { get; set; }
        public int ResolucionId { get; set; }
        public int TipoLugarId { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public string OperNotif { get; set; } = null!;
        public DateTime FechaNotif { get; set; }
        public bool Anulado { get; set; }

        public virtual Resolucione Resolucion { get; set; } = null!;
    }
}
