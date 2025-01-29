using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterDetalleMedicamento
    {
        public int IdDetalleMedicamentos { get; set; }
        public int IdEncabezadoMedicamento { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Dosis { get; set; }
        public decimal Precio { get; set; }
        public string? Factura { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public bool ACompartida { get; set; }
        public decimal Credito { get; set; }
        public int EncabezadoIdAcredita { get; set; }
        public decimal AcreditaPendiente { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InterEncabezadoMedicamento IdEncabezadoMedicamentoNavigation { get; set; } = null!;
    }
}
