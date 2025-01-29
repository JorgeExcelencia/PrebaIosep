using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Categoria_Aerobica
    {
        public Categoria_Aerobica()
        {
            Carrera_Inscripcions = new HashSet<Carrera_Inscripcion>();
        }

        public short IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public byte IdSexo { get; set; }
        public short Edad { get; set; }
        public string? Edad_Comparacion { get; set; }
        public bool Discapacidad { get; set; }

        public virtual ICollection<Carrera_Inscripcion> Carrera_Inscripcions { get; set; }
    }
}
