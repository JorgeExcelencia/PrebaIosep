using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Sectores_Iosep
    {
        public Sectores_Iosep()
        {
            Pat_Reparacion_Detalles = new HashSet<Pat_Reparacion_Detalle>();
            PedidoInterno_EncabezadoDestino_Sectors = new HashSet<PedidoInterno_Encabezado>();
            PedidoInterno_EncabezadoSolicita_Sectors = new HashSet<PedidoInterno_Encabezado>();
        }

        public int SectorId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Pat_Reparacion_Detalle> Pat_Reparacion_Detalles { get; set; }
        public virtual ICollection<PedidoInterno_Encabezado> PedidoInterno_EncabezadoDestino_Sectors { get; set; }
        public virtual ICollection<PedidoInterno_Encabezado> PedidoInterno_EncabezadoSolicita_Sectors { get; set; }
    }
}
