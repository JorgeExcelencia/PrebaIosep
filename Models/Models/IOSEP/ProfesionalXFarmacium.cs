using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProfesionalXFarmacium
    {
        public int ProfesionalXFarmaciaID { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Matricula { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int PrestadorDDJJID { get; set; }

        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}
