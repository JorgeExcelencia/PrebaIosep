using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_LugarPago
    {
        public Tipo_LugarPago()
        {
            LugarPagoDDJJs = new HashSet<LugarPagoDDJJ>();
            aportes = new HashSet<aporte>();
        }
        [Key]
        public int IdPago { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? Codigo { get; set; }
        public int? OrdenesExtras { get; set; }

        public virtual ICollection<LugarPagoDDJJ> LugarPagoDDJJs { get; set; }
        public virtual ICollection<aporte> aportes { get; set; }
    }
}
