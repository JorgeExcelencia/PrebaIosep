using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DelegacionPrestador
    {
        public int IdDelegacionPrestador { get; set; }
        public int IdDelegacion { get; set; }
        public int IdPrestador { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
