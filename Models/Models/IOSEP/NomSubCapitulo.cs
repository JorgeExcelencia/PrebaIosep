using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomSubCapitulo
    {
        public NomSubCapitulo()
        {
            NPracticas_Bases = new HashSet<NPracticas_Base>();
        }

        public int NomSubCapituloID { get; set; }
        public int NomCapituloID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual NomCapitulo NomCapitulo { get; set; } = null!;
        public virtual ICollection<NPracticas_Base> NPracticas_Bases { get; set; }
    }
}
