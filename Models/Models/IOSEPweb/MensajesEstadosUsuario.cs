using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesEstadosUsuario
    {
        public MensajesEstadosUsuario()
        {
            MensajesContactos = new HashSet<MensajesContacto>();
            MensajesGruposUsuarios = new HashSet<MensajesGruposUsuario>();
            MensajesNotificacionesBloqueados = new HashSet<MensajesNotificacionesBloqueado>();
            MensajesNotificacionesParas = new HashSet<MensajesNotificacionesPara>();
        }

        public string Usuario { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public byte[]? Avatar { get; set; }
        public bool? Notificaciones { get; set; }
        public bool? Sonido { get; set; }

        public virtual ICollection<MensajesContacto> MensajesContactos { get; set; }
        public virtual ICollection<MensajesGruposUsuario> MensajesGruposUsuarios { get; set; }
        public virtual ICollection<MensajesNotificacionesBloqueado> MensajesNotificacionesBloqueados { get; set; }
        public virtual ICollection<MensajesNotificacionesPara> MensajesNotificacionesParas { get; set; }
    }
}
