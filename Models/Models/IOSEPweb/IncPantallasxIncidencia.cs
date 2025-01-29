using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPantallasxIncidencia
    {
        public int PantallaxIncidenciaId { get; set; }
        public int TipoIncidenciaId { get; set; }
        public int PantallaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int Orden { get; set; }
        public string Tamano { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual IncPantalla Pantalla { get; set; } = null!;
        public virtual IncTiposIncidencia TipoIncidencia { get; set; } = null!;
    }
}
