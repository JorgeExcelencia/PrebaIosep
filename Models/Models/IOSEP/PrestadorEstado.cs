using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorEstado
    {
        public PrestadorEstado()
        {
            PrestadorDDJJs = new HashSet<PrestadorDDJJ>();
            PrestadorEstadoHistoricos = new HashSet<PrestadorEstadoHistorico>();
        }

        public int PrestadorEstadoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool BajaDefinitiva { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        public virtual ICollection<PrestadorDDJJ> PrestadorDDJJs { get; set; }
        public virtual ICollection<PrestadorEstadoHistorico> PrestadorEstadoHistoricos { get; set; }
    }
}
