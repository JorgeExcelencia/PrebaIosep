using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPantallasEsquema
    {
        public IncPantallasEsquema()
        {
            IncPantallasEsquemaRoles = new HashSet<IncPantallasEsquemaRole>();
        }

        public int PantallaEsquemaId { get; set; }
        public int PantallaId { get; set; }
        public int CampoId { get; set; }
        public bool Obligatorio { get; set; }
        public bool? Mostrar { get; set; }
        public int Orden { get; set; }
        public string Tamano { get; set; } = null!;
        public int? CampoIdhabilita { get; set; }
        public bool Anulado { get; set; }

        public virtual IncCampo Campo { get; set; } = null!;
        public virtual IncPantalla Pantalla { get; set; } = null!;
        public virtual ICollection<IncPantallasEsquemaRole> IncPantallasEsquemaRoles { get; set; }
    }
}
