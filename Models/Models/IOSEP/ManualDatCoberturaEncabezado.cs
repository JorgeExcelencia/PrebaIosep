using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ManualDatCoberturaEncabezado
    {
        public int ManualDatCoberturaID { get; set; }
        public string NombreArchivo { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
