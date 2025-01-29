using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class EventoDetalle
    {
        public int EventoDetalleId { get; set; }
        public int EventoEncabezadoId { get; set; }
        public int AnamnesisDetalleId { get; set; }
        public string? ValorAlmacenar { get; set; }
        public string? ValorId { get; set; }
        public bool Anulado { get; set; }

        public virtual AnamnesisDetalle AnamnesisDetalle { get; set; } = null!;
        public virtual EventoEncabezado EventoEncabezado { get; set; } = null!;
    }
}
