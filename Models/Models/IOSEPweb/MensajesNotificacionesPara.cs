using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesNotificacionesPara
    {
        public int NotificacionparaId { get; set; }
        public int NotificacionId { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime? Recibido { get; set; }
        public string? Respuesta { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }

        public virtual MensajesNotificacione Notificacion { get; set; } = null!;
        public virtual MensajesEstadosUsuario UsuarioNavigation { get; set; } = null!;
    }
}
