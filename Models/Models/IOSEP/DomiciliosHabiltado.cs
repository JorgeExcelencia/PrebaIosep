using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DomiciliosHabiltado
    {
        public DomiciliosHabiltado()
        {
            PrestadorDDJJDomiciliosHabilitados = new HashSet<PrestadorDDJJDomiciliosHabilitado>();
        }

        public int DomiciliosHabiltadosID { get; set; }
        public string? Nombre { get; set; }
        public string Domicilio { get; set; } = null!;
        public int LocalidadID { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime? FechaBaja { get; set; }
        public string? UsuarioBaja { get; set; }
        public string? NumeroHabilitacionMinisterial { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int DomicilioHabiltadoEstadoID { get; set; }
        public bool Anulado { get; set; }
        public string? Telefono { get; set; }

        public virtual ICollection<PrestadorDDJJDomiciliosHabilitado> PrestadorDDJJDomiciliosHabilitados { get; set; }
    }
}
