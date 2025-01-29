using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncSprint
    {
        public IncSprint()
        {
            IncSprintDetalles = new HashSet<IncSprintDetalle>();
        }

        public int SprintId { get; set; }
        public int ProyectoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Meta { get; set; }
        public DateTime FechaInicioAsignada { get; set; }
        public DateTime FechaFinAsignada { get; set; }
        public DateTime FechaInicioReal { get; set; }
        public DateTime? FechaFinReal { get; set; }
        public decimal DuracionSemanas { get; set; }
        public int CreaUsuarioId { get; set; }
        public DateTime CreaFecha { get; set; }
        public int? ModiUsuarioId { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyectosUsuario CreaUsuario { get; set; } = null!;
        public virtual IncProyectosUsuario? ModiUsuario { get; set; }
        public virtual IncProyecto Proyecto { get; set; } = null!;
        public virtual ICollection<IncSprintDetalle> IncSprintDetalles { get; set; }
    }
}
