using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InformeImpresion
    {
        public int IdInformeImpresion { get; set; }
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Web { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? FraseAnual { get; set; }
    }
}
