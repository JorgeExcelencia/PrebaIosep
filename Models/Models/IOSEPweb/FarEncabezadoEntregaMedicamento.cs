using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEncabezadoEntregaMedicamento
    {
        public FarEncabezadoEntregaMedicamento()
        {
            FarDetalleEntregaMedicamentos = new HashSet<FarDetalleEntregaMedicamento>();
        }

        public int IdEncabezadoEntregaMedicamentos { get; set; }
        public int IdEncabezadoVenta { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public int? IdAfiliado { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }

        public virtual FarEncabezadoVentum IdEncabezadoVentaNavigation { get; set; } = null!;
        public virtual ICollection<FarDetalleEntregaMedicamento> FarDetalleEntregaMedicamentos { get; set; }
    }
}
