using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CajaCierre
    {
        public CajaCierre()
        {
            CajaOperadores = new HashSet<CajaOperadore>();
            RendicionCajas = new HashSet<RendicionCaja>();
        }

        public int IdCierre { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Operador { get; set; } = null!;
        public decimal Total { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<CajaOperadore> CajaOperadores { get; set; }
        public virtual ICollection<RendicionCaja> RendicionCajas { get; set; }
    }
}
