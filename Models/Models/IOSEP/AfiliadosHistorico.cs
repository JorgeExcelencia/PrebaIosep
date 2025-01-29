using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadosHistorico
    {
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
        /// <summary>
        /// Esta fecha indica hasta cuando el afiliado puede operar en el sistema.
        /// Si se encuentra vacio tiene uso de la obra social ilimitado.
        /// </summary>
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
        public DateTime? Fecha_CtaCTe { get; set; }
        public string? Fliar { get; set; }
        public DateTime? FechaCrea { get; set; }
    }
}
