using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ventas_PtoVentum
    {
        public int IdPtoVenta { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Numero { get; set; }
        public bool Anulado { get; set; }
    }
}
