using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasRiesgo
    {
        public VacunasRiesgo()
        {
            VacunasMovimientos = new HashSet<VacunasMovimiento>();
        }

        public int RiesgoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Avatar { get; set; }
        public string IosepMsalud { get; set; } = null!;
        public byte Dosis { get; set; }
        public byte? MinEdad { get; set; }
        public byte? MaxEdad { get; set; }
        public string? Sexo { get; set; }
        public bool PideMeses { get; set; }
        public string? NombreMeses { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<VacunasMovimiento> VacunasMovimientos { get; set; }
    }
}
