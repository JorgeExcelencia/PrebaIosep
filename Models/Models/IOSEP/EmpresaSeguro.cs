using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EmpresaSeguro
    {
        public EmpresaSeguro()
        {
            SeguroMalaPraxis = new HashSet<SeguroMalaPraxi>();
        }

        public int EmpresaSeguroID { get; set; }
        public string Nombre { get; set; } = null!;
        public int LocalidadID { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<SeguroMalaPraxi> SeguroMalaPraxis { get; set; }
    }
}
