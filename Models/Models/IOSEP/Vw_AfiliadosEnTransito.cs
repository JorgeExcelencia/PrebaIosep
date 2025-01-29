using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_AfiliadosEnTransito
    {
        public string Nombre { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string? A_Numero { get; set; }
        public string? LugarPago { get; set; }
        public byte IdTipoDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public int? IdNacionalidad { get; set; }
        public byte IdSexo { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public short? IdDelegacion { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public bool? IosepSalud { get; set; }
        public int IdAfiliado { get; set; }
        public int IdLugarPago { get; set; }
    }
}
