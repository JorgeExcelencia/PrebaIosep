using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleValNP
    {
        public int ANSolicitudCambioDetalleValNPID { get; set; }
        public int ANSolicitudCambioDetalleNPID { get; set; }
        public decimal TotalHonorarios { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal ReconoceHonorarios { get; set; }
        public decimal ReconoceGastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }

        public virtual ANSolicitudCambioDetalleNP ANSolicitudCambioDetalleNP { get; set; } = null!;
    }
}
