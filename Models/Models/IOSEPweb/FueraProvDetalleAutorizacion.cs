using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FueraProvDetalleAutorizacion
    {
        public int IdDetalleAutorizacion { get; set; }
        public int IdDetallePresentacion { get; set; }
        public int IdEncabezado { get; set; }
        public int IdPractica { get; set; }
        public string Codigo { get; set; } = null!;
        public string Practica { get; set; } = null!;
        public byte Cantidad { get; set; }
        public int IdEfector { get; set; }
        public DateTime FechaPrestacion { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal DebitoHonorarios { get; set; }
        public decimal DebitoGastos { get; set; }
        public decimal CreditoHonorarios { get; set; }
        public decimal CreditoGastos { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual FueraProvDetallePresentacion IdDetallePresentacionNavigation { get; set; } = null!;
    }
}
