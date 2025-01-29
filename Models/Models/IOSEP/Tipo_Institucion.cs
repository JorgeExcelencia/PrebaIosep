using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Institucion
    {
        public Tipo_Institucion()
        {
            Reintegro_DetalleFacturas = new HashSet<Reintegro_DetalleFactura>();
        }

        public int TipoInstitucionID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? NombreCorto { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Reintegro_DetalleFactura> Reintegro_DetalleFacturas { get; set; }
    }
}
