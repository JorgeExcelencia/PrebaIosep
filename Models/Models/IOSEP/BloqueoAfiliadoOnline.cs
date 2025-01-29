using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class BloqueoAfiliadoOnline
    {
        public int BloqueoID { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPrestador { get; set; }
        public int Cantidad { get; set; }
        public DateTime? HastaFechaBloqueo { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}
