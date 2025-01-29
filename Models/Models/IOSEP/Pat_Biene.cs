using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Biene
    {
        public Pat_Biene()
        {
            Pat_DepreciacionDetalles = new HashSet<Pat_DepreciacionDetalle>();
            Pat_Mejoras = new HashSet<Pat_Mejora>();
            Pat_Reparacion_Detalles = new HashSet<Pat_Reparacion_Detalle>();
        }

        public int IdBien { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdGrupo_Bien { get; set; }
        public decimal Valor { get; set; }
        public byte VidaUtil { get; set; }
        public decimal Valorresidual { get; set; }
        public bool Depreciado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdSector { get; set; }
        public string DebeCompra { get; set; } = null!;
        public string HaberCompra { get; set; } = null!;
        public string DebeDepr { get; set; } = null!;
        public string HaberDepr { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;
        public DateTime FechaBaja { get; set; }

        public virtual Pat_GrupoBiene IdGrupo_BienNavigation { get; set; } = null!;
        public virtual ICollection<Pat_DepreciacionDetalle> Pat_DepreciacionDetalles { get; set; }
        public virtual ICollection<Pat_Mejora> Pat_Mejoras { get; set; }
        public virtual ICollection<Pat_Reparacion_Detalle> Pat_Reparacion_Detalles { get; set; }
    }
}
