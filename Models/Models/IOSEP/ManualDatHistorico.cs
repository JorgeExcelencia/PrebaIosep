using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ManualDatHistorico
    {
        public int IdManualDatHistorico { get; set; }
        public string? troquel { get; set; }
        public string? nombre { get; set; }
        public string? present { get; set; }
        public decimal? Ioma1 { get; set; }
        public string? Ioma2 { get; set; }
        public string? Ioma3 { get; set; }
        public string? laborat { get; set; }
        public decimal? precio { get; set; }
        public string? fecha { get; set; }
        public string? Marca { get; set; }
        public string? Importado { get; set; }
        public string? TipoVenta { get; set; }
        public string? Iva { get; set; }
        public string? Pami { get; set; }
        public int? CodLab { get; set; }
        public int? NroRegistro { get; set; }
        public string? Baja { get; set; }
        public string? barras { get; set; }
        public decimal? Unidades { get; set; }
        public string? Tamaño { get; set; }
        public string? Heladera { get; set; }
        public string? Sifar { get; set; }
        public string? Blanco { get; set; }
        public string? Gravamen { get; set; }
        public string? Blanco2 { get; set; }
        public DateTime? fec_act { get; set; }
        public decimal? precio2 { get; set; }
        public bool anulado { get; set; }
    }
}
