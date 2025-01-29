using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEncabezadoVentum
    {
        public FarEncabezadoVentum()
        {
            FarDetalleVenta = new HashSet<FarDetalleVenta>();
            FarEncabezadoEntregaMedicamentos = new HashSet<FarEncabezadoEntregaMedicamento>();
            FarEntregaMedicamentosPresentacionesDetalles = new HashSet<FarEntregaMedicamentosPresentacionesDetalle>();
            FarVentasPagos = new HashSet<FarVentasPago>();
        }

        public int IdEncabezadoVenta { get; set; }
        public int? IdAfiliado { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public int SucursalId { get; set; }
        public int IdTipoComprobante { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string? Estado { get; set; }
        public int? PrestadorId { get; set; }
        public int? PlanId { get; set; }
        public bool Derivado { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public string? OpCobra { get; set; }
        public DateTime? Cobra { get; set; }
        public bool Anulado { get; set; }
        public bool Ccv { get; set; }
        public string? Observaciones { get; set; }
        public string? ComprobanteOriginal { get; set; }
        public int? MotivoAnulaId { get; set; }
        public int? MotivoRestauraId { get; set; }
        public string? OperRestaura { get; set; }
        public DateTime? FechaRestaura { get; set; }

        public virtual FarTipoMovimiento IdTipoComprobanteNavigation { get; set; } = null!;
        public virtual FarSucursale Sucursal { get; set; } = null!;
        public virtual ICollection<FarDetalleVenta> FarDetalleVenta { get; set; }
        public virtual ICollection<FarEncabezadoEntregaMedicamento> FarEncabezadoEntregaMedicamentos { get; set; }
        public virtual ICollection<FarEntregaMedicamentosPresentacionesDetalle> FarEntregaMedicamentosPresentacionesDetalles { get; set; }
        public virtual ICollection<FarVentasPago> FarVentasPagos { get; set; }
    }
}
