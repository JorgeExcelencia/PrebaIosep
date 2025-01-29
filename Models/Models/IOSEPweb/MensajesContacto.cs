using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesContacto
    {
        public int ContantoId { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public DateTime Adherido { get; set; }
        public DateTime? Bloqueado { get; set; }
        public DateTime? Eliminado { get; set; }
        public DateTime? MeBloqueo { get; set; }
        public bool? Notificaciones { get; set; }
        public bool? Sonido { get; set; }
        public bool Anulado { get; set; }

        public virtual MensajesEstadosUsuario UsuarioNavigation { get; set; } = null!;
    }
}
