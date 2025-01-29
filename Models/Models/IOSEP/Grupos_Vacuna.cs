using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Grupos_Vacuna
    {
        public Grupos_Vacuna()
        {
            Movimientos_Vacunas = new HashSet<Movimientos_Vacuna>();
        }

        public int IdGrupos { get; set; }
        public string Nombre { get; set; } = null!;
        public string Plan { get; set; } = null!;
        public byte Orden { get; set; }
        public byte? Planilla { get; set; }

        public virtual ICollection<Movimientos_Vacuna> Movimientos_Vacunas { get; set; }
    }
}
