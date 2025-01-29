using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Gerenciador
    {
        public Gerenciador()
        {
            PrestadorDDJJGerenciadors = new HashSet<PrestadorDDJJGerenciador>();
        }

        public int GerenciadorID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Domicilio { get; set; } = null!;
        public string? Telefono { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJGerenciador> PrestadorDDJJGerenciadors { get; set; }
    }
}
