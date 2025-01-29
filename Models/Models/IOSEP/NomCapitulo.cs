using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomCapitulo
    {
        public NomCapitulo()
        {
            NomSubCapitulos = new HashSet<NomSubCapitulo>();
        }

        public int NomCapituloID { get; set; }
        public string? Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<NomSubCapitulo> NomSubCapitulos { get; set; }
    }
}
