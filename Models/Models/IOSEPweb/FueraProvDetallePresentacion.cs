using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FueraProvDetallePresentacion
    {
        public FueraProvDetallePresentacion()
        {
            FueraProvDetalleAutorizacions = new HashSet<FueraProvDetalleAutorizacion>();
        }

        public int IdDetallePresentacion { get; set; }
        public int IdEncabezado { get; set; }
        public int IdTipoPrestacion { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public int IdDiagnostico { get; set; }
        public bool Art { get; set; }
        public int IdGremio { get; set; }
        public bool Internacion { get; set; }
        public string? Protocolo { get; set; }
        public int Edad { get; set; }
        public string? NumeroAutorizacion { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? IdTipoInternacion { get; set; }
        public DateTime? FechaInternacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int DiasInternado { get; set; }
        public int IdClinica { get; set; }
        public int IdMotivoDevolucion { get; set; }
        public bool Chequeado { get; set; }
        public string? Observacion { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual FueraProvEncabezadoPresentacion IdEncabezadoNavigation { get; set; } = null!;
        public virtual ICollection<FueraProvDetalleAutorizacion> FueraProvDetalleAutorizacions { get; set; }
    }
}
