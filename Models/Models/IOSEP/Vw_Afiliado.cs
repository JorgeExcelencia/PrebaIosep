using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Afiliado
    {
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public byte Familiar { get; set; }
        public string Nombre { get; set; } = null!;
        public short Estado { get; set; }
        public byte Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
    }
}
