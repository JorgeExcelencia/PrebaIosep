using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Servicio
    {
        public Tipo_Servicio()
        {
            Tipo_Gastos = new HashSet<Tipo_Gasto>();
        }

        public int TipoServicioId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte Frecuencia_Meses { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Tipo_Gasto> Tipo_Gastos { get; set; }
    }
}
