using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterDetalleAutorizacion
    {
        public int IdDetalleAutorizacion { get; set; }
        public int IdDetalleProtocolo { get; set; }
        public int IdPractica { get; set; }
        public byte Renglon { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public byte CantidadSolicitada { get; set; }
        public byte CantidadAutorizada { get; set; }
        public DateTime? FechaPrestacion { get; set; }
        public int? IdEfector { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public decimal ReconoceHonorarios { get; set; }
        public decimal ReconoceGastos { get; set; }
        public decimal? FacturaHonorarios { get; set; }
        public decimal? FacturaGastos { get; set; }
        public int IdTipoDebitoHonorarios { get; set; }
        public int IdTipoDebitoGastos { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal DebitoHonorarios { get; set; }
        public decimal DebitoGastos { get; set; }
        public bool ACompartida { get; set; }
        public decimal CreditoHonorarios { get; set; }
        public decimal CreditoGastos { get; set; }
        public int EncabezadoIdAcredita { get; set; }
        public decimal AcreditaHonorariosPendiente { get; set; }
        public decimal AcreditaGastosPendiente { get; set; }
        public string? Observaciones { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
        public int IdRelacion { get; set; }

        public virtual InterDetalleProtocolo IdDetalleProtocoloNavigation { get; set; } = null!;
    }
}
