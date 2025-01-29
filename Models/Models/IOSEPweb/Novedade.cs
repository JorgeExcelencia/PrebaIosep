using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Novedade
    {
        public int NovedadId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Icono { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
    }
}
