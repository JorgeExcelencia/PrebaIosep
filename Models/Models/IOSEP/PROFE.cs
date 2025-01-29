using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PROFE
    {
        public byte Clave_ExCaja { get; set; }
        public byte Clave_Tipo { get; set; }
        public int Clave_Numero { get; set; }
        public byte Clave_Coparticipe { get; set; }
        public short Clave_Parentesco { get; set; }
        public string? LeyAplicada { get; set; }
        public string ApeNom { get; set; } = null!;
        public string? Sexo { get; set; }
        public byte? EstCivil { get; set; }
        public string Tipo_Doc { get; set; } = null!;
        public int Numero_Doc { get; set; }
        public DateTime? FeNac { get; set; }
        public byte? Incapacidad { get; set; }
        public DateTime Fech_Alta { get; set; }
        public string? Dom_Calle { get; set; }
        public int? Dom_Nro { get; set; }
        public short? Dom_Piso { get; set; }
        public string? Dom_Dpto { get; set; }
        public string? Cod_Pos { get; set; }
        public short Cug_Pcia { get; set; }
        public short Cug_Dpto { get; set; }
        public short Cug_loc { get; set; }
    }
}
