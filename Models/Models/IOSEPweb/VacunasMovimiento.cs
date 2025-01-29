using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasMovimiento
    {
        public VacunasMovimiento()
        {
            VacunasDetalleMovimientos = new HashSet<VacunasDetalleMovimiento>();
        }

        public int MovimientoId { get; set; }
        public int EncabezadoId { get; set; }
        public int RiesgoId { get; set; }
        public int PlanId { get; set; }
        public int PersonaId { get; set; }
        public int? AfiliadoId { get; set; }
        public int Edad { get; set; }
        public DateTime? FecNac { get; set; }
        public string? Sexo { get; set; }
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual VacunasEncabezado Encabezado { get; set; } = null!;
        public virtual VacunasPersona Persona { get; set; } = null!;
        public virtual VacunasPlan Plan { get; set; } = null!;
        public virtual VacunasRiesgo Riesgo { get; set; } = null!;
        public virtual ICollection<VacunasDetalleMovimiento> VacunasDetalleMovimientos { get; set; }
    }
}
