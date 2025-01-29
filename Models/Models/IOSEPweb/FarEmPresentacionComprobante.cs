using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEmPresentacionComprobante
    {
        public FarEmPresentacionComprobante()
        {
            FarEmPresentacionComprobanteDetalles = new HashSet<FarEmPresentacionComprobanteDetalle>();
        }

        public int FarEmpresentacionComprobanteId { get; set; }
        public int FarEmpresentacionId { get; set; }
        public int FarEntregaMedicacionId { get; set; }
        public int AfiliadoId { get; set; }
        public int? InstitucionId { get; set; }
        public int? TipoDebitoId { get; set; }
        public string NumeroAutorizacion { get; set; } = null!;
        public string? NumeroTicket { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal ImporteCoseguro { get; set; }
        public decimal ImporteIosep { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string? DebitoDetalle { get; set; }
        public decimal? DebitoImporte { get; set; }
        public bool AuditoriaRevisado { get; set; }
        public DateTime CreaFecha { get; set; }
        public string CreaOp { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual FarEmPresentacion FarEmpresentacion { get; set; } = null!;
        public virtual FarEntregaMedicacion FarEntregaMedicacion { get; set; } = null!;
        public virtual ICollection<FarEmPresentacionComprobanteDetalle> FarEmPresentacionComprobanteDetalles { get; set; }
    }
}
