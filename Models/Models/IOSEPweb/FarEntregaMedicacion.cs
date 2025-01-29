using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEntregaMedicacion
    {
        public FarEntregaMedicacion()
        {
            FarDetalleEntregaMedicacions = new HashSet<FarDetalleEntregaMedicacion>();
            FarEmPresentacionComprobantes = new HashSet<FarEmPresentacionComprobante>();
        }

        public int FarEntregaMedicacionId { get; set; }
        public int AfiliadoId { get; set; }
        public int FarEncabezadoVentaId { get; set; }
        public int TipoEntregaMedicacionId { get; set; }
        public int PrestadorId { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string? NumeroTicket { get; set; }
        public decimal ImporteTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoEntregaMedicacion TipoEntregaMedicacion { get; set; } = null!;
        public virtual ICollection<FarDetalleEntregaMedicacion> FarDetalleEntregaMedicacions { get; set; }
        public virtual ICollection<FarEmPresentacionComprobante> FarEmPresentacionComprobantes { get; set; }
    }
}
