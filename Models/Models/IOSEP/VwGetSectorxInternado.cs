using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwGetSectorxInternado
    {
        public int IdInternadoSector { get; set; }
        public int IdInternado { get; set; }
        public byte IdSector { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Pabellon { get; set; }
        public string? Cama { get; set; }
        public string? Denominacion { get; set; }
        public bool Activo { get; set; }
        public bool Anulada { get; set; }
    }
}
