using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MensajesGruposUsuario
    {
        public int GruposId { get; set; }
        public int GrupoId { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime Ingreso { get; set; }
        public DateTime? Salio { get; set; }

        public virtual MensajesGrupo Grupo { get; set; } = null!;
        public virtual MensajesEstadosUsuario UsuarioNavigation { get; set; } = null!;
    }
}
