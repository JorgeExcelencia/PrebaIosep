using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PlanillaTurno
    {
        public int PlanillaTurnoId { get; set; }
        public DateTime Fecha { get; set; }
        public short Turno { get; set; }
        public int ServicioId { get; set; }
        public int PrestadorId { get; set; }
        public int ConsultorioId { get; set; }
        public string Opcrea { get; set; } = null!;
        public string Opmodifica { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual Consultorio Consultorio { get; set; } = null!;
        public virtual Servicio Servicio { get; set; } = null!;
    }
}
