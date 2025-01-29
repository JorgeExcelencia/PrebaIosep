using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class RegistroAperturaLote
    {
        public int RegistroAperturaLoteId { get; set; }
        public int IdEncabezado { get; set; }
        public string TipoOrden { get; set; } = null!;
        public string OperApertura { get; set; } = null!;
        public DateTime FechaApertura { get; set; }
        public string? MotivoApertura { get; set; }
        public string OpeCierrePresentacion { get; set; } = null!;
        public DateTime FechaCierrePresentacion { get; set; }
        public string? NumeroFactura { get; set; }
        public string? MotivoAperturaComp { get; set; }
        public string? OpeCierreComp { get; set; }
        public DateTime? FechaCierreComp { get; set; }
    }
}
