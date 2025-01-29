using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesNotificacione
    {
        public MensajesNotificacione()
        {
            MensajesNotificacionesParas = new HashSet<MensajesNotificacionesPara>();
        }

        public int NotificacionId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Html { get; set; } = null!;
        public DateTime Enviado { get; set; }
        public string EnviadoPor { get; set; } = null!;
        /// <summary>
        /// T = TEXTO;
        /// C = NUEVO CONTACTO;
        /// R = RESOLUCION
        /// H = HTML
        /// </summary>
        public string Tipo { get; set; } = null!;

        public virtual ICollection<MensajesNotificacionesPara> MensajesNotificacionesParas { get; set; }
    }
}
