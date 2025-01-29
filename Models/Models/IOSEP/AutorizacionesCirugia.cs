using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AutorizacionesCirugia
    {
        public int IdAutorizacionesCirugias { get; set; }
        public int IdAutoriza { get; set; }
        public int IdInternado { get; set; }
        public int IdNomenclador { get; set; }
        public string Codigo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string MismaVia { get; set; } = null!;
        public bool? Anulado { get; set; }
    }
}
