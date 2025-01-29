using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestPlanificacionDetalle
    {
        public int PrestPlanificacionDetalleID { get; set; }
        public int PrestPlanificacionID { get; set; }
        public int? PrestPlanificacionDetalleIDModificado { get; set; }
        public int? ServicioPEEID { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }
        public bool Activo { get; set; }
        public bool Libre { get; set; }
        public string? Observacion { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public string? UsuarioModifica { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime? FechaModifica { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}
