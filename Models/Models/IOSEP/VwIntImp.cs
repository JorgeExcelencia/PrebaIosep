using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwIntImp
    {
        public string Cuil { get; set; } = null!;
        public int idinternado { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime fecha_internacion { get; set; }
        public DateTime? fecha_alta { get; set; }
        public string? MotivoAlta { get; set; }
        public string? Diagnostico { get; set; }
        public int idclinica { get; set; }
        public string Titular { get; set; } = null!;
        public string NombreTitular { get; set; } = null!;
        public short idestado { get; set; }
    }
}
