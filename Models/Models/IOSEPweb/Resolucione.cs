using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Resolucione
    {
        public Resolucione()
        {
            NotificacionResolucions = new HashSet<NotificacionResolucion>();
        }

        public int ResolucionId { get; set; }
        public string Serie { get; set; } = null!;
        public int Nro { get; set; }
        public int Anio { get; set; }
        public DateTime Fecha { get; set; }
        public short TipoResolucionId { get; set; }
        public string Referencia { get; set; } = null!;
        public string? NroExpediente { get; set; }
        public string? ReferenciaExpediente { get; set; }
        public string Caratula { get; set; } = null!;
        public DateTime FechaResolucion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string? SerieReemplaza { get; set; }
        public string? NroResolReemplaza { get; set; }
        public int? AnioResolReemplaza { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool? Digitalizada { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<NotificacionResolucion> NotificacionResolucions { get; set; }
    }
}
