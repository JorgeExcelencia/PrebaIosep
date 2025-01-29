using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosQuirofanoDetalle
    {
        public int QuirofanoDetalleID { get; set; }
        public int QuirofanoID { get; set; }
        public int EspecialistaID { get; set; }
        public int IdPrestador { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoEspecialista Especialista { get; set; } = null!;
        public virtual InternadosQuirofano Quirofano { get; set; } = null!;
    }
}
