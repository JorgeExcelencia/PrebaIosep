using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncEstadosXproyecto
    {
        public int IncEstadosXproyectoId { get; set; }
        public int EstadoId { get; set; }
        public int ProyectoId { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public int Orden { get; set; }
        public bool PorDefecto { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEstado Estado { get; set; } = null!;
        public virtual IncProyecto Proyecto { get; set; } = null!;
    }
}
