using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Reparacion_Detalle
    {
        public int IdRepDetalle { get; set; }
        public int IdReparacion { get; set; }
        public int IdBien { get; set; }
        public int IdSector { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Observaciones { get; set; } = null!;
        public bool Cerrada { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;

        public virtual Pat_Biene IdBienNavigation { get; set; } = null!;
        public virtual Pat_Reparacion IdReparacionNavigation { get; set; } = null!;
        public virtual Sectores_Iosep IdSectorNavigation { get; set; } = null!;
    }
}
