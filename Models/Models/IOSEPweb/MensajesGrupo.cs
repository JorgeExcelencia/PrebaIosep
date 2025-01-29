using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesGrupo
    {
        public MensajesGrupo()
        {
            Mensajes = new HashSet<Mensaje>();
            MensajesGruposUsuarios = new HashSet<MensajesGruposUsuario>();
        }

        public int GrupoId { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Creado { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<MensajesGruposUsuario> MensajesGruposUsuarios { get; set; }
    }
}
