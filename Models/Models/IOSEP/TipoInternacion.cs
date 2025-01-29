using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoInternacion
    {
        public TipoInternacion()
        {
            MovimientosInternados = new HashSet<MovimientosInternado>();
        }

        public int TipoInternacionID { get; set; }
        public string? codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Quirofano { get; set; }
        public bool RestriccionDia { get; set; }
        public bool EsAlta { get; set; }
        public bool Deriva { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<MovimientosInternado> MovimientosInternados { get; set; }
    }
}
