using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncEstado
    {
        public IncEstado()
        {
            IncEstadosXproyectos = new HashSet<IncEstadosXproyecto>();
            IncEventos = new HashSet<IncEvento>();
            IncFlujosMovimientos = new HashSet<IncFlujosMovimiento>();
            IncMovIncidencia = new HashSet<IncMovIncidencia>();
        }

        public int EstadoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncCategorium Categoria { get; set; } = null!;
        public virtual ICollection<IncEstadosXproyecto> IncEstadosXproyectos { get; set; }
        public virtual ICollection<IncEvento> IncEventos { get; set; }
        public virtual ICollection<IncFlujosMovimiento> IncFlujosMovimientos { get; set; }
        public virtual ICollection<IncMovIncidencia> IncMovIncidencia { get; set; }
    }
}
