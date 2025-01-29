using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EspecialidadDDJJ
    {
        public EspecialidadDDJJ()
        {
            PrestadorEspecialidadDDJJs = new HashSet<PrestadorEspecialidadDDJJ>();
        }

        public int EspecialidadDDJJID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool AtiendeOtroDomicilio { get; set; }
        public int AniosVigencia { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorEspecialidadDDJJ> PrestadorEspecialidadDDJJs { get; set; }
    }
}
