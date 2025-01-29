using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConvenioReciprocidad
    {
        public int ConvenioReciprocidadID { get; set; }
        public string ObraSocial { get; set; } = null!;
        public string? Domicilio { get; set; }
        public string? Telefono { get; set; }
        public int ProvinciaID { get; set; }
        public string? UsuarioCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}
