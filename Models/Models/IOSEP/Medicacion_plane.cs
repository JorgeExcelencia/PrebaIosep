using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Medicacion_plane
    {
        public int IdMedicacionPlan { get; set; }
        public int IdDetalle_Planes { get; set; }
        public int NuevaDro { get; set; }
        public string Observaciones { get; set; } = null!;
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual Planes_Detalle IdDetalle_PlanesNavigation { get; set; } = null!;
    }
}
