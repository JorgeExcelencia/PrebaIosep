using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaBase
    {
        public int NomPracticaBaseID { get; set; }
        public int? TipoPracticaID { get; set; }
        public int? NomCapituloID { get; set; }
        public int? NomSubCapituloID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }
    }
}
