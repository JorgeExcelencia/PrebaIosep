using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReintegroUsuarioSector
    {
        public int ReintegroUsuarioSectorID { get; set; }
        public string UsuarioID { get; set; } = null!;
        public int SectorReintegroID { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OperMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
