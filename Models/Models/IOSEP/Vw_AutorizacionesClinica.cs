using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_AutorizacionesClinica
    {
        public string Tipo { get; set; } = null!;
        public int IdAutoriza { get; set; }
        public int? Id { get; set; }
        public byte? Cantidad { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public int? IdPrescriptor { get; set; }
        public DateTime? Fecha_Prescripcion { get; set; }
        public DateTime? fecha_emision { get; set; }
        public decimal Auditor_Porcentaje { get; set; }
        public byte TipoAutorizacion { get; set; }
        public int? iddeTipo { get; set; }
        public int? Dias { get; set; }
        public string TipoIdAutoriza { get; set; } = null!;
    }
}
