using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class vw_AfiliadosDom
    {
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? A_Numero { get; set; }
        public bool Anulado { get; set; }
        public string? Domicilio { get; set; }
        public string? NroPuerta { get; set; }
        public string? Piso { get; set; }
        public string? Barrio { get; set; }
        public string? CodigoPostal { get; set; }
        public bool? DomAnulado { get; set; }
        public string? Localidad { get; set; }
        public DateTime Fecha_CtaCTe { get; set; }
        public DateTime FechaIngreso { get; set; }
        public short IdMotivoBaja { get; set; }
        public bool? IosepSalud { get; set; }
        public byte IdTipoFamiliar { get; set; }
    }
}
