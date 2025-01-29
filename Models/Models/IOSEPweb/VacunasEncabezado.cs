using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasEncabezado
    {
        public VacunasEncabezado()
        {
            VacunasMovimientos = new HashSet<VacunasMovimiento>();
        }

        public int EncabezadoId { get; set; }
        public int SedeId { get; set; }
        public string Ano { get; set; } = null!;
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual VacunasSede Sede { get; set; } = null!;
        public virtual ICollection<VacunasMovimiento> VacunasMovimientos { get; set; }
    }
}
