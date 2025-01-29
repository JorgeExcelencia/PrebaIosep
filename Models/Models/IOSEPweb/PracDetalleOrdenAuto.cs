using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracDetalleOrdenAuto
    {
        public int IdDetalleOrdenAuto { get; set; }
        public int IdDetallePresentacionAuto { get; set; }
        public int EncabezadoId { get; set; }
        public int IdPractica { get; set; }
        public string CodigoPractica { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public byte CantidadSolicitada { get; set; }
        public byte CantidadAutorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public int IdTipoDebito { get; set; }
        public string DetalleDebito { get; set; } = null!;
        public decimal Debitado { get; set; }
        public decimal Credito { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }

        public virtual PracDetallePresentacionAuto IdDetallePresentacionAutoNavigation { get; set; } = null!;
    }
}
