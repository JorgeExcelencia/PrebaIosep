using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarRemitoTemporalEncabezado
    {
        public FarRemitoTemporalEncabezado()
        {
            FarRemitoTemporalDetalles = new HashSet<FarRemitoTemporalDetalle>();
            FarRemitoTemporalPresentacionesDetalles = new HashSet<FarRemitoTemporalPresentacionesDetalle>();
        }

        public int IdEncabezadoTemporal { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public int SucursalOrigenId { get; set; }
        public int SucursalDestinoId { get; set; }
        public int EstadoId { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public DateTime? FechaRecibido { get; set; }
        public string? HoraRecibido { get; set; }
        public bool? RecibidoFaltantes { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoEstadoRemito Estado { get; set; } = null!;
        public virtual FarSucursale SucursalDestino { get; set; } = null!;
        public virtual FarSucursale SucursalOrigen { get; set; } = null!;
        public virtual ICollection<FarRemitoTemporalDetalle> FarRemitoTemporalDetalles { get; set; }
        public virtual ICollection<FarRemitoTemporalPresentacionesDetalle> FarRemitoTemporalPresentacionesDetalles { get; set; }
    }
}
