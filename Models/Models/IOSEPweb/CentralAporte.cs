using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class CentralAporte
    {
        public int IdCentralAporte { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Descripcion2 { get; set; }
        public bool Activo { get; set; }
        public bool IosepSalud { get; set; }
        public bool Anulado { get; set; }
    }
}
