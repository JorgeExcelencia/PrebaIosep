using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Prueba2
    {
        public int Id { get; set; }
        public int IdPrueba { get; set; }
        public string? Nombre { get; set; }
        public string? Detalle { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Prueba1 IdPruebaNavigation { get; set; } = null!;
    }
}
