using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwPresentacionFarmDetalle
    {
        public int EncabezadoId { get; set; }
        public string? CiuInstitucion { get; set; }
        public string? PeriodoPresentacion { get; set; }
        public string? ConceptoPresentacion { get; set; }
        public bool? IosepSalud { get; set; }
        public decimal? ImportePresentado { get; set; }
        public decimal? CoseguroPresentado { get; set; }
        public int? CantidadRegistros { get; set; }
        public int? RegistrosCorrectos { get; set; }
        public int? RegistrosFallidos { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaSubida { get; set; }
        public int ErrorId { get; set; }
        public int? Nroreg { get; set; }
        public string? Periodo { get; set; }
        public string? CiuFarmacia { get; set; }
        public string? Mensaje { get; set; }
        public decimal? Presentado { get; set; }
        public string? NumeroOrden { get; set; }
        public string? NombreInstitucion { get; set; }
        public decimal? TotalDebitado { get; set; }
        public decimal? Debitado { get; set; }
    }
}
