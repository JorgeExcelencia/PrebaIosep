using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracDetallePresentacion
    {
        public PracDetallePresentacion()
        {
            PracDetalleOrdens = new HashSet<PracDetalleOrden>();
        }

        public int IdDetallePresentacion { get; set; }
        public int EncabezadoId { get; set; }
        public int IdPrestador { get; set; }
        public int? IdPrestadorLiquida { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public DateTime FechaPractica { get; set; }
        public int IdAfiliado { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public int IdTipoDebito { get; set; }
        public string? DetalleDebito { get; set; }
        public decimal? Debitado { get; set; }
        public string? OperadorCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int? IdLegajoColegio { get; set; }
        public string? PeriodoDevolucion { get; set; }
        public bool Devolucion { get; set; }
        public bool Refacturable { get; set; }
        public bool SugiereDebito { get; set; }
        public bool Chequeado { get; set; }
        public bool? Internado { get; set; }
        public int? IdInternado { get; set; }
        public bool ACompartida { get; set; }
        public bool Anulado { get; set; }

        public virtual PracEncabezadoPresentacion Encabezado { get; set; } = null!;
        public virtual ICollection<PracDetalleOrden> PracDetalleOrdens { get; set; }
    }
}
