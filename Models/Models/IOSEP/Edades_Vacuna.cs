using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Edades_Vacuna
    {
        public Edades_Vacuna()
        {
            Movimientos_Vacunas = new HashSet<Movimientos_Vacuna>();
        }

        public int IdEdades { get; set; }
        public string Nombre { get; set; } = null!;
        public byte Orden { get; set; }
        public int IdTiempo { get; set; }

        public virtual ICollection<Movimientos_Vacuna> Movimientos_Vacunas { get; set; }
    }
}
