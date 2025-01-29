using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAfiliadosDdjjFamiliar
    {
        public byte IdSexo { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public byte IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? ApellidoMaterno { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public int? IdNacionalidad { get; set; }
        public string? Nacionalidad { get; set; }
        public byte? IdSexoGenero { get; set; }
        public string Sexo { get; set; } = null!;
        public string? SexoGenero { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public string EstadoCivil { get; set; } = null!;
        public DateTime FechadeNacimiento { get; set; }
        public short? IdDelegacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public short IdMotivoBaja { get; set; }
        public DateTime? FechadeBaja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public string? TipoFamiliar { get; set; }
        public short? IdCategoria { get; set; }
        public int? IdLugarPago { get; set; }
        public byte? IdSituacionLaboral { get; set; }
        public bool Anulado { get; set; }
        public string MotivoBaja { get; set; } = null!;
        public string Delegacion { get; set; } = null!;
        public string CuilaBuscar { get; set; } = null!;
        public int IdDdjj { get; set; }
    }
}
