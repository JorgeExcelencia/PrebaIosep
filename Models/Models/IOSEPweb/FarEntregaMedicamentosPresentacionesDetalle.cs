using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEntregaMedicamentosPresentacionesDetalle
    {
        public int IdEntregaMedicamentosDetallePresentacion { get; set; }
        public int IdEntregaMedicamentosPresentacion { get; set; }
        public int IdEncabezadoVenta { get; set; }
        public bool Anulado { get; set; }

        public virtual FarEncabezadoVentum IdEncabezadoVentaNavigation { get; set; } = null!;
        public virtual FarEntregaMedicamentosPresentacione IdEntregaMedicamentosPresentacionNavigation { get; set; } = null!;
    }
}
