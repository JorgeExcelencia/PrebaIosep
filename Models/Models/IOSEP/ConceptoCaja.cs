using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConceptoCaja
    {
        public ConceptoCaja()
        {
            CajaOperadores = new HashSet<CajaOperadore>();
        }

        public int IdConcepto { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdParent { get; set; }
        public int? IdPlan { get; set; }
        public string? TipoOrden { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<CajaOperadore> CajaOperadores { get; set; }
    }
}
