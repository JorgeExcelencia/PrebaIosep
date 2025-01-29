using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Menu
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public string Action { get; set; } = null!;
        public int Parent { get; set; }
        public byte Orden1 { get; set; }
        public byte Orden2 { get; set; }
        public byte Orden3 { get; set; }
        public byte Orden4 { get; set; }
        public byte Orden5 { get; set; }
        public byte Orden6 { get; set; }
        public string? Imagen { get; set; }
    }
}
