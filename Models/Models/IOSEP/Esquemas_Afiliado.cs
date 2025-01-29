using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Esquemas_Afiliado
    {
        public Esquemas_Afiliado()
        {
            Medicacion_Esquemas = new HashSet<Medicacion_Esquema>();
            Practicas_esquemas = new HashSet<Practicas_esquema>();
        }

        public int IdEsquema { get; set; }
        public int IdAfiliado { get; set; }
        public string? Observaciones { get; set; }
        public string? Resolucion { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Vencimiento { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Medicacion_Esquema> Medicacion_Esquemas { get; set; }
        public virtual ICollection<Practicas_esquema> Practicas_esquemas { get; set; }
    }
}
