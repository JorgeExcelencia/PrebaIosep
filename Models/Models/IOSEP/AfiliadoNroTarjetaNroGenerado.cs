using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadoNroTarjetaNroGenerado
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public string? OpAnula { get; set; }
    }
}
