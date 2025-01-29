using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ParametrosHoraHabilDetalle
    {
        public int IdParametrosHoraHabilDet { get; set; }
        public int IdParametrosHoraHabil { get; set; }
        public int IdClinica { get; set; }
        public int Horas { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public string UsuarioCrea { get; set; } = null!;

        public virtual ParametrosHoraHabil IdParametrosHoraHabilNavigation { get; set; } = null!;
    }
}
