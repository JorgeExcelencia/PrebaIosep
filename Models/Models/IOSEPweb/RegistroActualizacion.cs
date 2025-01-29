using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class RegistroActualizacion
    {
        public int RegistroActualizacionId { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string OperadorActualiza { get; set; } = null!;
        public int TipoEntidadId { get; set; }
        public string EntidadActualizadaId { get; set; } = null!;
        public int TipoActualizacionId { get; set; }
        public string? DescripcionActualizacion { get; set; }
        public string? Adicional { get; set; }

        public virtual TipoActualizacion TipoActualizacion { get; set; } = null!;
        public virtual TipoEntidad TipoEntidad { get; set; } = null!;
    }
}
