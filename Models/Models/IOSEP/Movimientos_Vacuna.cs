using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Movimientos_Vacuna
    {
        public int IdMovimientos { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdVacuna { get; set; }
        public int? IdEdad { get; set; }
        public int? IdCentro { get; set; }
        public int? IdGrupo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? Avisado { get; set; }

        public virtual Edades_Vacuna? IdEdadNavigation { get; set; }
        public virtual Grupos_Vacuna? IdGrupoNavigation { get; set; }
    }
}
