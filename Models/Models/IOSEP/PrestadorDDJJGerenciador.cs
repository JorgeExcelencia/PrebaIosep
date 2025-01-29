using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJGerenciador
    {
        public int PrestadorDDJJGerenciadorID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int GerenciadorID { get; set; }
        public string? CondigoIdentificador { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual Gerenciador Gerenciador { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}
