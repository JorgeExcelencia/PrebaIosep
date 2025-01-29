using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Mensaje
    {
        public int MensajeId { get; set; }
        public string Mensaje1 { get; set; } = null!;
        public DateTime Enviado { get; set; }
        public DateTime? Recibido { get; set; }
        public DateTime? Leido { get; set; }
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public int? GrupoId { get; set; }
        public string? Ip { get; set; }

        public virtual MensajesGrupo? Grupo { get; set; }
    }
}
