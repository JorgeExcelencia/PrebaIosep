using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReintegroSectore
    {
        public int ReintegroSectoresID { get; set; }
        public int ReintegrosEncabezadoID { get; set; }
        public int SectorOrigenID { get; set; }
        public int SectorDestinoID { get; set; }
        public string? UsuarioEnvia { get; set; }
        public DateTime? FechaEnvia { get; set; }
        public bool Activo { get; set; }
        public bool Anulado { get; set; }
    }
}
