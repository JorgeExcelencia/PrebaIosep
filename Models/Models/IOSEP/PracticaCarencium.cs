using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PracticaCarencium
    {
        public int IdPracticaCarencia { get; set; }
        public int IdPractica { get; set; }
        public int Dias { get; set; }
        public int TopeSem { get; set; }
        public int TopeMen { get; set; }
        public int TopeTri { get; set; }
        public int TopeAnu { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
