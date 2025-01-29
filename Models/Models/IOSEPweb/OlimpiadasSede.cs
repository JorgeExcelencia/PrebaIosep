using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class OlimpiadasSede
    {
        public OlimpiadasSede()
        {
            OlimpiadasEncabezados = new HashSet<OlimpiadasEncabezado>();
        }

        public int SedeId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<OlimpiadasEncabezado> OlimpiadasEncabezados { get; set; }
    }
}
