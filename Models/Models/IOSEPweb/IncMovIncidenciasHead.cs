using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncMovIncidenciasHead
    {
        public IncMovIncidenciasHead()
        {
            IncCamposGuardados = new HashSet<IncCamposGuardado>();
            IncEtiquetasDetalles = new HashSet<IncEtiquetasDetalle>();
            IncMovComentarios = new HashSet<IncMovComentario>();
            IncMovIncidencia = new HashSet<IncMovIncidencia>();
            IncMovIncidenciaAdjuntos = new HashSet<IncMovIncidenciaAdjunto>();
            IncSprintDetalles = new HashSet<IncSprintDetalle>();
            IncVotos = new HashSet<IncVoto>();
        }

        public int MovIncidenciaHeadId { get; set; }
        public int ProyectoId { get; set; }
        public int TipoIncidenciaId { get; set; }
        public int InformadorId { get; set; }
        public int? ResponsableId { get; set; }
        public int PrioridadId { get; set; }
        public string? PuntoHistoria { get; set; }
        public DateTime FechaCreado { get; set; }
        public DateTime? FechaCambio { get; set; }
        public int? SubTareaDe { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyectosUsuario Informador { get; set; } = null!;
        public virtual IncPrioridad Prioridad { get; set; } = null!;
        public virtual IncProyecto Proyecto { get; set; } = null!;
        public virtual IncProyectosUsuario? Responsable { get; set; }
        public virtual IncTiposIncidencia TipoIncidencia { get; set; } = null!;
        public virtual ICollection<IncCamposGuardado> IncCamposGuardados { get; set; }
        public virtual ICollection<IncEtiquetasDetalle> IncEtiquetasDetalles { get; set; }
        public virtual ICollection<IncMovComentario> IncMovComentarios { get; set; }
        public virtual ICollection<IncMovIncidencia> IncMovIncidencia { get; set; }
        public virtual ICollection<IncMovIncidenciaAdjunto> IncMovIncidenciaAdjuntos { get; set; }
        public virtual ICollection<IncSprintDetalle> IncSprintDetalles { get; set; }
        public virtual ICollection<IncVoto> IncVotos { get; set; }
    }
}
