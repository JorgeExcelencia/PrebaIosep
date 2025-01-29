using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Dia
    {
        public Dia()
        {
            PrestadorDia = new HashSet<PrestadorDia>();
            ServiciosDia = new HashSet<ServiciosDia>();
        }

        public int DiaId { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<PrestadorDia> PrestadorDia { get; set; }
        public virtual ICollection<ServiciosDia> ServiciosDia { get; set; }
    }
}
