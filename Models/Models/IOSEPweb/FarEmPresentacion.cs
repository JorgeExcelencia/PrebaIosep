using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarEmPresentacion
    {
        public FarEmPresentacion()
        {
            FarEmPresentacionComprobanteDetalles = new HashSet<FarEmPresentacionComprobanteDetalle>();
            FarEmPresentacionComprobantes = new HashSet<FarEmPresentacionComprobante>();
        }

        public int FarEmpresentacionId { get; set; }
        public int? InstitucionId { get; set; }
        public string Periodo { get; set; } = null!;
        public int ObraSocialId { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteCoseguro { get; set; }
        public decimal ImporteDebitado { get; set; }
        public decimal ImporteIosep { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal ImporteDescuento { get; set; }
        public decimal ImporteIosepFinal { get; set; }
        public int CantidadRegistros { get; set; }
        public int CantidadDebitos { get; set; }
        public string? NumeroFactura { get; set; }
        public DateTime? CierreFecha { get; set; }
        public string? CierreOp { get; set; }
        public DateTime? CierreAuditoriaFecha { get; set; }
        public string? CierreAuditoriaOp { get; set; }
        public DateTime CreaFecha { get; set; }
        public string CreaOp { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<FarEmPresentacionComprobanteDetalle> FarEmPresentacionComprobanteDetalles { get; set; }
        public virtual ICollection<FarEmPresentacionComprobante> FarEmPresentacionComprobantes { get; set; }
    }
}
