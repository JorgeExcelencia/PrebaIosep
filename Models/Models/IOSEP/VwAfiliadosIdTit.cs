using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAfiliadosIdTit
    {
        public int IdTitular { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public byte IdTipoDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string? ApellidoMaterno { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public int? IdNacionalidad { get; set; }
        public byte IdSexo { get; set; }
        public byte? IdSexoGenero { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public short? IdDelegacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public short IdMotivoBaja { get; set; }
        public DateTime? FechadeBaja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public short? IdCategoria { get; set; }
        public int? IdLugarPago { get; set; }
        public byte? IdSituacionLaboral { get; set; }
        public string? A_Numero { get; set; }
        public int? DbfAfiliado { get; set; }
        public int? DbfGrupo { get; set; }
        public bool? IosepSalud { get; set; }
        public string? LetArc { get; set; }
        public string? CodArc { get; set; }
        public bool Anulado { get; set; }
        public DateTime Fecha_CtaCTe { get; set; }
        public DateTime FecNacTit { get; set; }
    }
}
