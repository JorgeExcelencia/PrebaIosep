using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEntregaMedicamentosPresentacione
    {
        public FarEntregaMedicamentosPresentacione()
        {
            FarEntregaMedicamentosPresentacionesDetalles = new HashSet<FarEntregaMedicamentosPresentacionesDetalle>();
        }

        public int IdEntregaMedicamentosPresentacion { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FarEntregaMedicamentosPresentacionesDetalle> FarEntregaMedicamentosPresentacionesDetalles { get; set; }
    }
}
