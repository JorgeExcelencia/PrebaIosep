using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncMovIncidenciaAdjunto
    {
        public int MovAdjuntosId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Archivo { get; set; }
        public string? Formato { get; set; }
        public int? SizeBytes { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaCreado { get; set; }
        public bool Anulado { get; set; }

        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
        public virtual IncProyectosUsuario Usuario { get; set; } = null!;
    }
}
