using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenesExtra
    {
        public int Id { get; set; }
        public int IdAfiliado { get; set; }
        public short Consultas { get; set; }
        public short Monodroga { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Observaciones { get; set; } = null!;
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? AnulaOperador { get; set; }
        public DateTime? AnulaFecha { get; set; }
        public bool Anulado { get; set; }
    }
}
