using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_AutorizacionesMedicamento
    {
        public int IdAutoriza { get; set; }
        public int? IdAfiliado { get; set; }
        public string Numero { get; set; } = null!;
        public int? IdPrescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int NroRegistro { get; set; }
        public byte? Cantidad { get; set; }
        public DateTime? Fecha_Prescripcion { get; set; }
        public DateTime? Fecha_Emision { get; set; }
        public int? IddeTipo { get; set; }
        public string Medicamento { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public byte? TipoId { get; set; }
        public int? IdInternado { get; set; }
        public bool? Anulado { get; set; }
        public decimal Auditor_Porcentaje { get; set; }
        public byte TipoAutorizacion { get; set; }
        public int IdManual { get; set; }
        public DateTime? Fecha_Internacion { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public int? Dias { get; set; }
    }
}
