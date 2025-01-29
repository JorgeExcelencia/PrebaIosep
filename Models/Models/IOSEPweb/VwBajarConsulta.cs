using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwBajarConsulta
    {
        public int IdEncabezadoConsultas { get; set; }
        public DateTime Fecha { get; set; }
        public string PeriodoPresentacion { get; set; } = null!;
        public byte Concepto { get; set; }
        public int IdObraSocial { get; set; }
        public int IdInstitucion { get; set; }
        public byte Complementaria { get; set; }
        public string Efector { get; set; } = null!;
        public string Prestador { get; set; } = null!;
        public DateTime FechaPractica { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string CodigoPractica { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal? Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public string? Diagnostico { get; set; }
        public decimal Debitado { get; set; }
        public string? CodigoDebito { get; set; }
        public string DetalleDebito { get; set; } = null!;
        public string? CodigoColegio { get; set; }
        public string? ColegioLiquida { get; set; }
        public int Cantidad { get; set; }
        public decimal PorcentajeCategoria { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public int IdDetalleConsultas { get; set; }
    }
}
