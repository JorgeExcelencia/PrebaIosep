using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class BioquimicosConsumo
    {
        public BioquimicosConsumo()
        {
            BioquimicosEncabezados = new HashSet<BioquimicosEncabezado>();
        }

        public int IdBioquimicosConsumo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public int TotalRegistros { get; set; }
        public decimal Importe { get; set; }
        public bool Confirmado { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<BioquimicosEncabezado> BioquimicosEncabezados { get; set; }
    }
}
