using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoOperabilidad
    {
        public int TipoOperabilidadID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Prestador { get; set; }
        public bool Afiliado { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
