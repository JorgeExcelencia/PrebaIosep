using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Plane
    {
        public Plane()
        {
            Encabezado_Autorizaciones = new HashSet<Encabezado_Autorizacione>();
            Planes_Afiliados = new HashSet<Planes_Afiliado>();
            Planes_Detalles = new HashSet<Planes_Detalle>();
        }

        public int IdPlan { get; set; }
        public string Nombre { get; set; } = null!;
        public bool GrupoFliar { get; set; }
        public string? Relacion { get; set; }
        public bool? Especial { get; set; }
        public bool? Estandar { get; set; }
        public int? DiasVence { get; set; }
        public bool? Informacion { get; set; }
        public bool? Iosep { get; set; }
        public bool Anulado { get; set; }
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool FueraProvincia { get; set; }
        public bool DiasCobertura { get; set; }
        public bool? Online { get; set; }
        public bool? HC { get; set; }
        public bool? CambBono { get; set; }

        public virtual ICollection<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; }
        public virtual ICollection<Planes_Afiliado> Planes_Afiliados { get; set; }
        public virtual ICollection<Planes_Detalle> Planes_Detalles { get; set; }
    }
}
