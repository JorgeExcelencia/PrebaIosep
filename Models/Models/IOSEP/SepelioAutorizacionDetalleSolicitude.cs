using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SepelioAutorizacionDetalleSolicitude
    {
        public int SepelioAutorizacionDetalleSolicitudesID { get; set; }
        public int SepelioSolicitudFacturacionID { get; set; }
        public int SepelioAutorizacionID { get; set; }
        public bool Estado { get; set; }

        public virtual SepelioAutorizacion SepelioAutorizacion { get; set; } = null!;
    }
}
