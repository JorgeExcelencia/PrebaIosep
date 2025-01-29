using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterDetalleProtocolo
    {
        public InterDetalleProtocolo()
        {
            InterDetalleAutorizacions = new HashSet<InterDetalleAutorizacion>();
        }

        public int IdDetalleProtocolo { get; set; }
        public int IdDetallePresentacion { get; set; }
        public int IdPlan { get; set; }
        public string NumeroAutorizacion { get; set; } = null!;
        public byte Edad { get; set; }
        public DateTime FechaEmision { get; set; }
        public int IdPrescriptor { get; set; }
        public int IdDiagnostico { get; set; }
        public decimal Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? CoseguroHonorarios { get; set; }
        public decimal? CoseguroGastos { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public bool Refacturable { get; set; }
        public bool SugiereDebito { get; set; }
        public bool ACompartida { get; set; }
        public string? Observaciones { get; set; }
        public string OperadorCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InterDetallePresentacion IdDetallePresentacionNavigation { get; set; } = null!;
        public virtual ICollection<InterDetalleAutorizacion> InterDetalleAutorizacions { get; set; }
    }
}
