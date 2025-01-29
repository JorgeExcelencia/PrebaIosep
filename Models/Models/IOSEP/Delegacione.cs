using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Delegacione
    {
        public Delegacione()
        {
            Encabezado_Autorizaciones = new HashSet<Encabezado_Autorizacione>();
            PracticasDelegacions = new HashSet<PracticasDelegacion>();
        }

        public short IdDelegacion { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? IdLocalidad { get; set; }
        public string? Domicilio { get; set; }
        public bool Anulado { get; set; }
        public bool? informatizada { get; set; }
        public bool? TrabajaComoIOSEPSalud { get; set; }
        public string? Telefono { get; set; }
        public bool? ConsultasInf { get; set; }
        public bool? MonodrogasInf { get; set; }
        public bool? PracticasInf { get; set; }
        public bool Limitrofe { get; set; }
        public int? IdProvLimitrofe { get; set; }

        public virtual ICollection<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; }
        public virtual ICollection<PracticasDelegacion> PracticasDelegacions { get; set; }
    }
}
