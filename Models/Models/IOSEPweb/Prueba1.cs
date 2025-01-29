using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Prueba1
    {
        public Prueba1()
        {
            Prueba2s = new HashSet<Prueba2>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Detalle { get; set; }

        public virtual ICollection<Prueba2> Prueba2s { get; set; }
    }
}
