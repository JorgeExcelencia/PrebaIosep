using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AcreditacionesMedica
    {
        public AcreditacionesMedica()
        {
            PrestadorDDJJAcreditacionMedicas = new HashSet<PrestadorDDJJAcreditacionMedica>();
        }

        public int AcreditacionesMedicaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool AtiendeOtroDomicilio { get; set; }
        public int AniosVigencia { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJAcreditacionMedica> PrestadorDDJJAcreditacionMedicas { get; set; }
    }
}
