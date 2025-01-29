using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Servicio
    {
        public Servicio()
        {
            PlanillaTurnos = new HashSet<PlanillaTurno>();
            PrestadoresServicios = new HashSet<PrestadoresServicio>();
            ServiciosDia = new HashSet<ServiciosDia>();
            TurnosServicios = new HashSet<TurnosServicio>();
        }

        public int ServicioId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Internado { get; set; }
        public bool Guardia { get; set; }
        public int TvMonitorId { get; set; }
        public int EspecilidadId { get; set; }
        public int PrestadorId { get; set; }
        public int TipoPedidoId { get; set; }
        public bool Anulado { get; set; }

        public virtual Especialidade Especilidad { get; set; } = null!;
        public virtual ICollection<PlanillaTurno> PlanillaTurnos { get; set; }
        public virtual ICollection<PrestadoresServicio> PrestadoresServicios { get; set; }
        public virtual ICollection<ServiciosDia> ServiciosDia { get; set; }
        public virtual ICollection<TurnosServicio> TurnosServicios { get; set; }
    }
}
