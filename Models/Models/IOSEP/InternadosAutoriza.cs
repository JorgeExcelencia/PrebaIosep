using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosAutoriza
    {
        public int InternadosAutorizaID { get; set; }
        public int IdInternado { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdTitular { get; set; }
        public int? IdClinica { get; set; }
        public int? IdDiagnostico { get; set; }
        public DateTime? Fecha_Internacion { get; set; }
        public byte? Edad { get; set; }
        public bool? Hijo { get; set; }
        public bool? Art { get; set; }
        public bool? AccidenteTansito { get; set; }
        public bool? Anulada { get; set; }
        public string? UserCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
    }
}
