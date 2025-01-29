using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TablaAuxMedicamentosCompara
    {
        public int Id { get; set; }
        public int? NroRegistro { get; set; }
        public string? Medicamento { get; set; }
        public string? Presentacion { get; set; }
        public string? Laboratorio { get; set; }
        public decimal? PrecioI1 { get; set; }
        public decimal? PrecioF1 { get; set; }
        public decimal? PrecioI2 { get; set; }
        public decimal? PrecioF2 { get; set; }
        public decimal? PrecioI3 { get; set; }
        public decimal? PrecioF3 { get; set; }
        public decimal? PrecioI4 { get; set; }
        public decimal? PrecioF4 { get; set; }
        public bool? Baja { get; set; }
    }
}
