using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracDetalleOrden
    {
        public PracDetalleOrden()
        {
            PracHistoricoCodigos = new HashSet<PracHistoricoCodigo>();
        }

        public int IdDetalleOrden { get; set; }
        public int IdDetallePresentacion { get; set; }
        public int? EncabezadoId { get; set; }
        public int IdPractica { get; set; }
        public string? NombrePractica { get; set; }
        public string? CodigoPractica { get; set; }
        public byte CantidadSolicitada { get; set; }
        public byte CantidadAutorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public decimal ReconoceHonorarios { get; set; }
        public decimal ReconoceGastos { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public decimal Credito { get; set; }
        public int? EncabezadoIdacredita { get; set; }
        public decimal? CreditoPendiente { get; set; }
        public string? Observaciones { get; set; }
        public bool ACompartida { get; set; }
        public bool Anulado { get; set; }

        public virtual PracDetallePresentacion IdDetallePresentacionNavigation { get; set; } = null!;
        public virtual ICollection<PracHistoricoCodigo> PracHistoricoCodigos { get; set; }
    }
}
