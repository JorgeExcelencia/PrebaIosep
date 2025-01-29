using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesNotificacionesBloqueado
    {
        public int BloqueoId { get; set; }
        public string Usuario { get; set; } = null!;
        public string Bloqueado { get; set; } = null!;
        public bool Notificaciones { get; set; }
        public bool Anulado { get; set; }

        public virtual MensajesEstadosUsuario UsuarioNavigation { get; set; } = null!;
    }
}
